namespace NovoRestoDaDivisao
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
            this.lblDividendo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.txtResto = new System.Windows.Forms.TextBox();
            this.lblResto = new System.Windows.Forms.Label();
            this.btnRealizarDivisao = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDividendo.Location = new System.Drawing.Point(12, 41);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(120, 25);
            this.lblDividendo.TabIndex = 0;
            this.lblDividendo.Text = "Dividendo: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNICIARToolStripMenuItem
            // 
            this.iNICIARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sOBREToolStripMenuItem});
            this.iNICIARToolStripMenuItem.Name = "iNICIARToolStripMenuItem";
            this.iNICIARToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.iNICIARToolStripMenuItem.Text = "Iniciar";
            // 
            // sOBREToolStripMenuItem
            // 
            this.sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
            this.sOBREToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sOBREToolStripMenuItem.Text = "Sobre";
            this.sOBREToolStripMenuItem.Click += new System.EventHandler(this.sOBREToolStripMenuItem_Click);
            // 
            // txtDividendo
            // 
            this.txtDividendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDividendo.Location = new System.Drawing.Point(130, 35);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(195, 31);
            this.txtDividendo.TabIndex = 1;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisor.Location = new System.Drawing.Point(130, 74);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(195, 31);
            this.txtDivisor.TabIndex = 2;
            this.txtDivisor.TextChanged += new System.EventHandler(this.txtDivisor_TextChanged);
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisor.Location = new System.Drawing.Point(12, 74);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(90, 25);
            this.lblDivisor.TabIndex = 3;
            this.lblDivisor.Text = "Divisor: ";
            // 
            // txtResto
            // 
            this.txtResto.Enabled = false;
            this.txtResto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResto.Location = new System.Drawing.Point(509, 35);
            this.txtResto.Name = "txtResto";
            this.txtResto.Size = new System.Drawing.Size(195, 31);
            this.txtResto.TabIndex = 8;
            // 
            // lblResto
            // 
            this.lblResto.AutoSize = true;
            this.lblResto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResto.Location = new System.Drawing.Point(331, 38);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(187, 25);
            this.lblResto.TabIndex = 7;
            this.lblResto.Text = "Resto da Divisao: ";
            // 
            // btnRealizarDivisao
            // 
            this.btnRealizarDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarDivisao.Location = new System.Drawing.Point(336, 74);
            this.btnRealizarDivisao.Name = "btnRealizarDivisao";
            this.btnRealizarDivisao.Size = new System.Drawing.Size(368, 31);
            this.btnRealizarDivisao.TabIndex = 3;
            this.btnRealizarDivisao.Text = "Realizar Divisao";
            this.btnRealizarDivisao.UseVisualStyleBackColor = true;
            this.btnRealizarDivisao.Click += new System.EventHandler(this.btnRealizarDivisao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 126);
            this.Controls.Add(this.btnRealizarDivisao);
            this.Controls.Add(this.txtResto);
            this.Controls.Add(this.lblResto);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.lblDividendo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOBREToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.TextBox txtResto;
        private System.Windows.Forms.Label lblResto;
        private System.Windows.Forms.Button btnRealizarDivisao;
    }
}

