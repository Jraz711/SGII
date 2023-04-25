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

namespace SGII.Admin
{
    public partial class Modify : Form
    {
        int id=0;
        public Modify()
        {
            InitializeComponent();
        }
        public Modify(int id)
        {
            this.id = id;
            if (id == 0)
            {
                Close();
            }
            InitializeComponent();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actualizar();
            Close();
        }

        private void Actualizar()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=JRAZ711\\SQLEXPRESS;Initial Catalog=SGII;Integrated Security=True";

            conn.Open();

            string str = $"Update [User] Set Username=@Username,Password=@Password,Name=@Name,LastName=@LastName,Email=@Email,IdRol=@IdRol,Estatus=@Estatus" +
                $" where id={id}";

            SqlCommand cmd = new SqlCommand(str);

            cmd.Parameters.AddWithValue("@Username", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            cmd.Parameters.AddWithValue("@Name", textBox4.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox5.Text);
            cmd.Parameters.AddWithValue("@Email", textBox6.Text);
            cmd.Parameters.AddWithValue("@IdRol", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Estatus", comboBox2.Text);

            cmd.Connection = conn;

            cmd.ExecuteNonQuery();

            conn.Close();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            M_User f = new M_User();
            f.Show();
            this.Hide();
        }
    }
}
