using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reforzamiento
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        Form1 f = new Form1();
        Form2 f2 = new Form2();
        Form3 f3 = new Form3(); 
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        Form7 f7 = new Form7();

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void calculoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.IsMdiContainer = true;
            f.Show();
        }

        private void velocidadLinealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.IsMdiContainer= true;
            f2.Show();  
        }

        private void numerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.IsMdiContainer= true;
            f3.Show();
        }

        private void numerosPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.IsMdiContainer=true;
            f4.Show();
        }

        private void conversosDeTemperaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.IsMdiContainer = true;
            f5.Show();
        }

        private void tablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f7.IsMdiContainer = true;
            f7.Show();
        }
    }
}
