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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txt1.Enabled = false;
            txt2.Enabled = false;
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

        private void txt2_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

            double cel, kel, fah;

            try { 

                if (cmb1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una opcion");
            }
            else
            {
                if (cmb1.SelectedItem.Equals("Celsius"))
                {
                    cel = double.Parse(txt3.Text);
                    kel = (cel * (9 / 5)) + 32;
                    fah = cel + 273.15;

                    txt1.Text = fah.ToString();
                    txt2.Text = kel.ToString();
                }
                else
                {
                    if (cmb1.SelectedItem.Equals("Fahrenheit"))
                    {
                        fah = double.Parse(txt1.Text);
                        kel = (fah - 32) * 9 / 5 + 273.15;
                        cel = (fah - 32) * 9 / 5;
                        txt2.Text = kel.ToString();
                        txt3.Text = cel.ToString();

                    }
                    else
                    {
                        if (cmb1.SelectedItem.Equals("Kelvin"))
                        {
                            kel = double.Parse(txt2.Text);
                            fah = (kel - 273.15) * 9 / 5 + 32;
                            cel = kel - 273.15;
                            txt1.Text = fah.ToString();
                            txt3.Text = cel.ToString();
                        }
                    }
                }
            }
        }catch (Exception)
            {
                MessageBox.Show("No puede ser nulo");
            }
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1.SelectedItem.Equals("Celsius"))
            {
                txt1.Enabled= false;
                txt2.Enabled= false;
                txt3.Enabled= true;
            }
            else if (cmb1.SelectedItem.Equals("Fahrenheit"))
            {
                txt1.Enabled = true;
                txt2.Enabled = false;
                txt3.Enabled = false;
            }
            else
            {
                txt1.Enabled = false;
                txt2.Enabled = true;
                txt3.Enabled = false;
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}