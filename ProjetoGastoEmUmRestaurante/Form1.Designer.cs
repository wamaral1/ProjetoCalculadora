namespace ProjetoGastoEmUmRestaurante
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtComGorjeta = new System.Windows.Forms.TextBox();
            this.lblComGorjeta = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inciarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inciarToolStripMenuItem
            // 
            this.inciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.inciarToolStripMenuItem.Name = "inciarToolStripMenuItem";
            this.inciarToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inciarToolStripMenuItem.Text = "Inciar";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Location = new System.Drawing.Point(12, 42);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(52, 13);
            this.lblDespesa.TabIndex = 1;
            this.lblDespesa.Text = "Despesa:";
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(71, 42);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(100, 20);
            this.txtDespesa.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(177, 40);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtComGorjeta
            // 
            this.txtComGorjeta.BackColor = System.Drawing.Color.Yellow;
            this.txtComGorjeta.Enabled = false;
            this.txtComGorjeta.Location = new System.Drawing.Point(105, 76);
            this.txtComGorjeta.Name = "txtComGorjeta";
            this.txtComGorjeta.Size = new System.Drawing.Size(150, 20);
            this.txtComGorjeta.TabIndex = 5;
            // 
            // lblComGorjeta
            // 
            this.lblComGorjeta.AutoSize = true;
            this.lblComGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComGorjeta.ForeColor = System.Drawing.Color.Blue;
            this.lblComGorjeta.Location = new System.Drawing.Point(12, 79);
            this.lblComGorjeta.Name = "lblComGorjeta";
            this.lblComGorjeta.Size = new System.Drawing.Size(98, 13);
            this.lblComGorjeta.TabIndex = 4;
            this.lblComGorjeta.Text = "Total com 10%: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 110);
            this.Controls.Add(this.txtComGorjeta);
            this.Controls.Add(this.lblComGorjeta);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDespesa);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gasto em Restaurante";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtComGorjeta;
        private System.Windows.Forms.Label lblComGorjeta;
    }
}

