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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGII.Admin
{
    public partial class M_Roles : Form
    {
        public M_Roles()
        {
            InitializeComponent();
        }

        private void M_Roles_Load(object sender, EventArgs e)
        {
            
            consultarTodo();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            insertar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void consultarTodo()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=JRAZ711\\SQLEXPRESS;Initial Catalog=SGII;Integrated Security=True";

            conn.Open();

            string str = "SELECT * FROM [Rol]";

            SqlCommand cmd = new SqlCommand(str);

            cmd.Connection = conn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();


        }

        private void buscarrol()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=JRAZ711\\SQLEXPRESS;Initial Catalog=SGII;Integrated Security=True";

            conn.Open();

            string str = "SELECT * FROM [rol] where IdRol = @IdRol";

            SqlCommand cmd = new SqlCommand(str);

            cmd.Parameters.AddWithValue("@IdRol", textBox1.Text);

            cmd.Connection = conn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();


        }

        private void insertar()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=JRAZ711\\SQLEXPRESS;Initial Catalog=SGII;Integrated Security=True";

            conn.Open();

            string str = "INSERT INTO [Rol](Descripcion) VALUES( @Descripcion)";

            SqlCommand cmd = new SqlCommand(str);

            cmd.Parameters.AddWithValue("@Descripcion", textBox2.Text);


            cmd.Connection = conn;

            cmd.ExecuteNonQuery();

            conn.Close();

            consultarTodo();
        }

        private void eliminar()
        {

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=JRAZ711\\SQLEXPRESS;Initial Catalog=SGII;Integrated Security=True";

            conn.Open();

            string str = "DELETE [rol] WHERE IdRol  = @IdRol";

            SqlCommand cmd = new SqlCommand(str);

            cmd.Parameters.AddWithValue("@IdRol", textBox1.Text);

            cmd.Connection = conn;

            cmd.ExecuteNonQuery();

            conn.Close();

            consultarTodo();
        }

        private void Actualizar()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=JRAZ711\\SQLEXPRESS;Initial Catalog=SGII;Integrated Security=True";

            conn.Open();

            string str = $"Update [Rol] Set Descripcion=@Descripcion" +
                $" where IdRol= @IdRol";

            SqlCommand cmd = new SqlCommand(str);

            cmd.Parameters.AddWithValue("@Descripcion", textBox2.Text);
            cmd.Parameters.AddWithValue("@IdRol", textBox1.Text);

            cmd.Connection = conn;

            cmd.ExecuteNonQuery();

            conn.Close();

            consultarTodo();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMain AM = new AdminMain();
            AM.Show();
            this.Hide();
        }
    }
}
