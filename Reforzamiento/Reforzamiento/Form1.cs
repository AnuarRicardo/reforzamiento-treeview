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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Enabled = true;    
            txt2.Enabled = true;
            txt3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1, n2, total;
                n1 = int.Parse(txt1.Text);
                n2 = int.Parse(txt2.Text);
                if(n1 < 0 || n1 > 50 || n2 < 0 || n2 > 50)
                {
                    MessageBox.Show("La nota no puede ser negativa ni mayor a 50");
                }
                else
                {
                    total = n1 + n2;
                    if(total < 60)
                    {
                        MessageBox.Show("El estudiante esta reprobado");
                        txt3.Text = total.ToString();
                    }
                    else
                    {
                        if (total >= 60)
                        {
                            MessageBox.Show("El estudiante esta aprobado");
                            txt3.Text = total.ToString();
                        }
                    }
                }





            }catch (Exception)
            {
                MessageBox.Show("No puede ser nulo");
            }
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
            int nota1;
            nota1 = int.Parse(txt1.Text);
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            int nota2;
            nota2 = int.Parse(txt2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
