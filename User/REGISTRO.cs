using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            
                SqlConnection conn = new SqlConnection();

                conn.ConnectionString = "Data Source=DESKTOP-0UKK8GV\\SQLEXPRESS;Initial Catalog=SGII;Integrated Security=True";

                conn.Open();

                string str = "INSERT INTO [User](Username,Password, Name ,LastName,Email,IdRol,Estatus) VALUES( @Username,@Password, @Name ,@LastName,@Email,@IdRol,@Estatus)";

                SqlCommand cmd = new SqlCommand(str);

                cmd.Parameters.AddWithValue("@Username", textBox3.Text);
                cmd.Parameters.AddWithValue("@Password", textBox4.Text);
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@LastName", textBox1.Text);
                cmd.Parameters.AddWithValue("@Email", textBox6.Text);
                cmd.Parameters.AddWithValue("@IdRol", "3");
                cmd.Parameters.AddWithValue("@Estatus", "1");

                cmd.Connection = conn;

                cmd.ExecuteNonQuery();

                conn.Close();

            Login d = new Login();
            d.Show();
            this.Hide();

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
