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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txt1.Enabled = true;   
            txt2.Enabled = true;
            txt3.Enabled = true;
            txt4.Enabled = true;
            txt5.Enabled = false;
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

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
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
            double num1;
            num1 = double.Parse(txt1.Text);
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            double num2;
            num2 = double.Parse(txt2.Text);
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            double num3;
            num3 = double.Parse(txt3.Text);
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            double num4;
            num4 = double.Parse(txt4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, tot, media;
            try
            {
                n1 = double.Parse(txt1.Text);
                n2 = double.Parse(txt2.Text);
                n3 = double.Parse(txt3.Text);
                n4 = double.Parse(txt4.Text);

                if (n1 < 0 || n2 < 0 || n3 < 0 || n4 < 0) 
                {
                    MessageBox.Show("No puede ser menor a cero");
                }
                else
                {
                    tot = n1 + n2 + n3 + n4;
                    media = tot / 4;
                    txt5.Text = media.ToString();
                }

            }catch (Exception)
            {
                MessageBox.Show("No puede ser nulo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
