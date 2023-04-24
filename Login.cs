using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGII
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginAdmin d = new LoginAdmin();
            d.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MyConnection db = new MyConnection();
                using (db.con)
                {
                    SqlCommand cmd = new SqlCommand("sp_SGII", db.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    db.con.Open();
                    cmd.Parameters.AddWithValue("@uname", textBox1.Text);
                    cmd.Parameters.AddWithValue("@upass", textBox2.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd[6].ToString() == "1")
                        {
                            MyConnection.rol = "SA";
                        }
                        else if (rd[6].ToString() == "2")
                        {
                            MyConnection.rol = "A";
                        }
                        Pantalla_principal d = new Pantalla_principal();
                        d.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                    db.con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uSERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login d = new Login();
            d.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            REGISTRO d = new REGISTRO();
            d.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
