using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGII
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            M_User f = new M_User();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            M_User f = new M_User();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            M_User f = new M_User ();
            f.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            if (MyConnection.rol == "SA")
            {
                button1.Visible = true;
                button2.Visible = true;
                button2.Visible = true;
                
            

            }
            else if (MyConnection.rol == "A")
            {
                button1.Visible = false;
                button2.Visible = true;
                button2.Visible = true;
        

            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginAdmin f = new LoginAdmin();
            f.Show();
            this.Hide();
        }
    }
}
