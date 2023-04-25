using SGII;
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

namespace SGII.User
{
    public partial class ventana_de_usuario : Form
    {
        public ventana_de_usuario()
        {
            InitializeComponent();
        }

        private void ventana_de_usuario_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=DESKTOP-0UKK8GV\\SQLEXPRESS;Initial Catalog=SGII;Integrated Security=True";

            conn.Open();

            string str = "SELECT [Username],[Password],[Name],[LastName],[Email] FROM [dbo].[User]" ;

            SqlDataAdapter cmd = new SqlDataAdapter(str, conn);
            DataTable datos = new DataTable();
            cmd.Fill(datos);
            dataGridView1.DataSource= datos;

            conn.Close();
          

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedCells[e.RowIndex].ToString();
            textBox1.Text = dataGridView1.SelectedCells[e.RowIndex].ToString();
            textBox3.Text = dataGridView1.SelectedCells[e.RowIndex].ToString();
            textBox4.Text = dataGridView1.SelectedCells[e.RowIndex].ToString();
            textBox6.Text = dataGridView1.SelectedCells[e.RowIndex].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla_principal d = new Pantalla_principal();
            d.Show();
            this.Hide();
        }
    }
}
