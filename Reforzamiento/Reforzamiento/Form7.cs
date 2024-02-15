using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Reforzamiento
{
    public partial class Form7 : Form
    {

        private int n = 0;
        
        public Form7()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtCant.Text))
            {
                MessageBox.Show("No se pueden agregar columnas si estan vacias");
            }
            else
            {

            


            int n = dataGridView1.Rows.Add();
            double subtot, p, tot1;
            int c;

            dataGridView1.Rows[n].Cells[0].Value = txtCodigo.Text;
            dataGridView1.Rows[n].Cells[1].Value = txtNombre.Text;
            dataGridView1.Rows[n].Cells[2].Value = txtPrecio.Text;
            dataGridView1.Rows[n].Cells[3].Value = txtCant.Text;


            c = int.Parse(txtCant.Text);
            p = double.Parse(txtPrecio.Text);

            if (c < 0 || p < 0)
            {
                MessageBox.Show("No puede ser negativo");
            }
            else
            {
                 
                subtot = c * p;
                
                
                txtSub.Text = subtot.ToString();
                dataGridView1.Rows[n].Cells[4].Value = txtSub.Text;
                

                double c4 = 0, iva, tot=0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    c4 += Convert.ToInt32(row.Cells["Column5"].Value);
                }
                
                iva = c4 * 0.15;
                tot = c4 + iva;

                   txtSubFact.Text = c4.ToString();
                   txtTot.Text = tot.ToString();
                }
                

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCant.Text = "";
       

        }
   }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if(n != -1)
            {
                lblinfo.Text = (string)dataGridView1.Rows[n].Cells[1].Value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(n!= -1)
            {
                dataGridView1.Rows.RemoveAt(n);
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            txtSub.Enabled = false;
            txtSubFact.Enabled = false;
            txtTot.Enabled = false;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< dataGridView1.Rows.Count; i++)
            {
                int rowIndex = i + 1;
                TreeNode node = new TreeNode("Row_" +rowIndex);
                for(int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    node.Nodes.Add(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
                treeView1.Nodes.Add(node);
            }
        }
    }
}