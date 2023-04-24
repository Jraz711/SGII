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
    public partial class Pantalla_principal : Form
    {
        public Pantalla_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void cONFIGURACONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantalla_principal d = new Pantalla_principal();
            d.ShowDialog();
            this.Hide();
        }
    }
}
