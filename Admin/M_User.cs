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
    public partial class M_User : Form
    {
        //MyConnection db = new MyConnection();
        public M_User()
        {
            InitializeComponent();
        }
        private void M_User_Load(object sender, EventArgs e)
        {
            //string consulta = "select * from user";
            //SqlDataAdapter adapter = new SqlDataAdapter(consulta,db.con);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignupAdmin f = new SignupAdmin();
            f.ShowDialog();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMain AM = new AdminMain();
            AM.ShowDialog();
            this.Hide();
        }


        private void button4_Click(object sender, EventArgs e)

        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            consultarTodo();

        }

        private void consultarTodo()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=JRAZ711\\SQLEXPRESS;Initial Catalog=SGII;Integrated Security=True";

            conn.Open();

            string str = "SELECT Username, Name ,LastName,Email,IdRol FROM [User]";

            SqlCommand cmd = new SqlCommand(str);

            cmd.Connection = conn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();


        }

        private void eliminar()
        {

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=JRAZ711\\SQLEXPRESS;Initial Catalog=SGII;Integrated Security=True";

            conn.Open();

            string str = "DELETE [User] WHERE Id  = @Id";

            SqlCommand cmd = new SqlCommand(str);

            //cmd.Parameters.AddWithValue("@MATRICULA", TxtMatricula.Text);

            cmd.Connection = conn;

            cmd.ExecuteNonQuery();

            conn.Close();

            consultarTodo();
        }











    }
}
