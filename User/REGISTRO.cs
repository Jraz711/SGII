﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGII
{
    public partial class REGISTRO : Form
    {
        

        public REGISTRO()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyConnection db = new MyConnection();
            using (db.con) { 
            
            SqlCommand comando = new SqlCommand("Almacenar_SGII");
                comando.CommandType = CommandType.StoredProcedure;
                db.con.Open();
                comando.Parameters.AddWithValue("@Username", textBox3.Text);
            comando.Parameters.AddWithValue("@Name", textBox1.Text);
            comando.Parameters.AddWithValue("@LastName", textBox2.Text);
            comando.Parameters.AddWithValue("PassWord", textBox4.Text);
            comando.Parameters.AddWithValue("@Email", textBox6.Text);

                try
                {
                    comando.ExecuteNonQuery();
                }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                db.con.Close();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login d = new Login();
            d.Show();
            this.Hide();
        }

        private void REGISTRO_Load(object sender, EventArgs e)
        {

        }

        
    }
}
