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
    public partial class LoginAdmin : Form
    {
        
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
                        AdminMain d = new AdminMain ();
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
                MessageBox.Show(ex.Message);
            }
           
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginAdmin d = new LoginAdmin();
            d.ShowDialog();
            this.Hide();
                    }

        private void uSERToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void uSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login d = new Login();
            d.Show();
            this.Hide();
        }

        private void LoginAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            { 
            button1_Click(null,null );
            }
        }
    }
}
