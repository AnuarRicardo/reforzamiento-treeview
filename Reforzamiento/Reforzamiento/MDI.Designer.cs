namespace Reforzamiento
{
    partial class MDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.velocidadLinealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numerosPrimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversosDeTemperaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deprecciacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculoDeNotasToolStripMenuItem,
            this.velocidadLinealToolStripMenuItem,
            this.numerosToolStripMenuItem,
            this.numerosPrimosToolStripMenuItem,
            this.conversosDeTemperaturasToolStripMenuItem,
            this.deprecciacionToolStripMenuItem,
            this.tablaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // calculoDeNotasToolStripMenuItem
            // 
            this.calculoDeNotasToolStripMenuItem.Name = "calculoDeNotasToolStripMenuItem";
            this.calculoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.calculoDeNotasToolStripMenuItem.Text = "Calculo de Notas";
            this.calculoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.calculoDeNotasToolStripMenuItem_Click);
            // 
            // velocidadLinealToolStripMenuItem
            // 
            this.velocidadLinealToolStripMenuItem.Name = "velocidadLinealToolStripMenuItem";
            this.velocidadLinealToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.velocidadLinealToolStripMenuItem.Text = "Velocidad Lineal";
            this.velocidadLinealToolStripMenuItem.Click += new System.EventHandler(this.velocidadLinealToolStripMenuItem_Click);
            // 
            // numerosToolStripMenuItem
            // 
            this.numerosToolStripMenuItem.Name = "numerosToolStripMenuItem";
            this.numerosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.numerosToolStripMenuItem.Text = "Calculo de media";
            this.numerosToolStripMenuItem.Click += new System.EventHandler(this.numerosToolStripMenuItem_Click);
            // 
            // numerosPrimosToolStripMenuItem
            // 
            this.numerosPrimosToolStripMenuItem.Name = "numerosPrimosToolStripMenuItem";
            this.numerosPrimosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.numerosPrimosToolStripMenuItem.Text = "Numeros Primos";
            this.numerosPrimosToolStripMenuItem.Click += new System.EventHandler(this.numerosPrimosToolStripMenuItem_Click);
            // 
            // conversosDeTemperaturasToolStripMenuItem
            // 
            this.conversosDeTemperaturasToolStripMenuItem.Name = "conversosDeTemperaturasToolStripMenuItem";
            this.conversosDeTemperaturasToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.conversosDeTemperaturasToolStripMenuItem.Text = "Conversos de Temperaturas";
            this.conversosDeTemperaturasToolStripMenuItem.Click += new System.EventHandler(this.conversosDeTemperaturasToolStripMenuItem_Click);
            // 
            // deprecciacionToolStripMenuItem
            // 
            this.deprecciacionToolStripMenuItem.Name = "deprecciacionToolStripMenuItem";
            this.deprecciacionToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.deprecciacionToolStripMenuItem.Text = "Deprecciacion";
            // 
            // tablaToolStripMenuItem
            // 
            this.tablaToolStripMenuItem.Name = "tablaToolStripMenuItem";
            this.tablaToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.tablaToolStripMenuItem.Text = "Tabla";
            this.tablaToolStripMenuItem.Click += new System.EventHandler(this.tablaToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "MDI";
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem velocidadLinealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numerosPrimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversosDeTemperaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deprecciacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaToolStripMenuItem;
    }
}