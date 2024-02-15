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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
         
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
           
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

        private void button1_Click(object sender, EventArgs e)
        {
            int num;

            try
            {
                num = int.Parse(txt1.Text);
                if (num < 0)
                {
                    MessageBox.Show("No puede ser negativo");
                }
                else
                {
                    bool esprimo = true;
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            esprimo = false;
                        }
                        if (esprimo)
                        {
                            txt2.Text = "Es primo";
                        }
                        else
                        {
                            txt2.Text = "No es primo";
                        }
                    }
                }


            }catch (Exception)
            {
                MessageBox.Show("No puede ser nulo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           txt1.Clear();
           txt2.Clear();   
           txt1.Focus();   
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
