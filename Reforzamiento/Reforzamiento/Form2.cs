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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = false;
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            double dist;
            dist = double.Parse(txt1.Text);
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            double tiemp;
            tiemp = double.Parse(txt2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double d, t, tot;
                d = double.Parse(txt1.Text);
                t = double.Parse(txt2.Text);

                if (d <= 0 || d > 100000)
                {
                    MessageBox.Show("No puede ser negativo ni cero, ni mayor a 100,000");
                }
                else
                {
                    if (t <= 0 || t > 10000)
                    {
                        MessageBox.Show("No puede ser negativo ni cero, ni mayor a 10,000");
                    }
                    else
                    {
                        tot = d / t;
                        txt3.Text = tot.ToString(); 
                        
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No puede ser nulo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
