namespace ProjetoCalculadora
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
            this.lblValor1 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.comboBoxOperacao = new System.Windows.Forms.ComboBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnExecutarOperacao = new System.Windows.Forms.Button();
            this.btnLimparDados = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informacoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.Location = new System.Drawing.Point(26, 51);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(86, 25);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1:";
            this.lblValor1.Click += new System.EventHandler(this.lblValor1_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(141, 51);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(232, 31);
            this.txtValor1.TabIndex = 1;
            this.txtValor1.TextChanged += new System.EventHandler(this.txtValor1_TextChanged);
            // 
            // comboBoxOperacao
            // 
            this.comboBoxOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperacao.FormattingEnabled = true;
            this.comboBoxOperacao.Items.AddRange(new object[] {
            "SOMAR",
            "SUBTRAIR",
            "MULTIPLICAR",
            "DIVIDIR"});
            this.comboBoxOperacao.Location = new System.Drawing.Point(141, 156);
            this.comboBoxOperacao.Name = "comboBoxOperacao";
            this.comboBoxOperacao.Size = new System.Drawing.Size(232, 33);
            this.comboBoxOperacao.TabIndex = 3;
            this.comboBoxOperacao.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperacao_SelectedIndexChanged);
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(141, 102);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(232, 31);
            this.txtValor2.TabIndex = 2;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor2.Location = new System.Drawing.Point(26, 102);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(86, 25);
            this.lblValor2.TabIndex = 3;
            this.lblValor2.Text = "Valor 2:";
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.Location = new System.Drawing.Point(26, 156);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(112, 25);
            this.lblOperacao.TabIndex = 5;
            this.lblOperacao.Text = "Operacao:";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Black;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.White;
            this.txtResultado.Location = new System.Drawing.Point(141, 258);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(232, 31);
            this.txtResultado.TabIndex = 7;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(26, 258);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(115, 25);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnExecutarOperacao
            // 
            this.btnExecutarOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutarOperacao.Location = new System.Drawing.Point(31, 210);
            this.btnExecutarOperacao.Name = "btnExecutarOperacao";
            this.btnExecutarOperacao.Size = new System.Drawing.Size(342, 33);
            this.btnExecutarOperacao.TabIndex = 4;
            this.btnExecutarOperacao.Text = "EXECUTAR OPERACAO";
            this.btnExecutarOperacao.UseVisualStyleBackColor = true;
            this.btnExecutarOperacao.Click += new System.EventHandler(this.btnExecutarOperacao_Click);
            // 
            // btnLimparDados
            // 
            this.btnLimparDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparDados.Location = new System.Drawing.Point(31, 307);
            this.btnLimparDados.Name = "btnLimparDados";
            this.btnLimparDados.Size = new System.Drawing.Size(342, 33);
            this.btnLimparDados.TabIndex = 5;
            this.btnLimparDados.Text = "LIMPAR DADOS";
            this.btnLimparDados.UseVisualStyleBackColor = true;
            this.btnLimparDados.Click += new System.EventHandler(this.btnLimparDados_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacoesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informacoesToolStripMenuItem
            // 
            this.informacoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.informacoesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacoesToolStripMenuItem.Name = "informacoesToolStripMenuItem";
            this.informacoesToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.informacoesToolStripMenuItem.Text = "INICIAR";
            this.informacoesToolStripMenuItem.Click += new System.EventHandler(this.informacoesToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "SOBRE";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(400, 368);
            this.Controls.Add(this.btnLimparDados);
            this.Controls.Add(this.btnExecutarOperacao);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.comboBoxOperacao);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Simples";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.ComboBox comboBoxOperacao;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnExecutarOperacao;
        private System.Windows.Forms.Button btnLimparDados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informacoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

