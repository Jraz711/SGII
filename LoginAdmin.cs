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
        MyConnection db = new MyConnection();
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
                        if (rd[7].ToString() == "1")
                        {
                            MyConnection.rol = "SA";
                        }
                        else if (rd[7].ToString() == "2")
                        {
                            MyConnection.rol = "A";
                        }
                        MessageBox.Show("Welcome " + textBox1.Text);

                        AdminMain d = new AdminMain ();
                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
