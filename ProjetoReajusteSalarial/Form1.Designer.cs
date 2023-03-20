namespace ProjetoReajusteSalarial
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNoturno = new System.Windows.Forms.RadioButton();
            this.radioButtonVespertino = new System.Windows.Forms.RadioButton();
            this.radioButtonMatutino = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonCalouro = new System.Windows.Forms.RadioButton();
            this.radioButtonVeterano = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtSituacaoRemuneracao = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.iniciarToolStripMenuItem.Text = "Informacoes";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salário Mínimo: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(118, 46);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(144, 20);
            this.txtSalarioMinimo.TabIndex = 1;
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(118, 72);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(144, 20);
            this.txtHorasTrabalhadas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horas Trabalhadas: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNoturno);
            this.groupBox1.Controls.Add(this.radioButtonVespertino);
            this.groupBox1.Controls.Add(this.radioButtonMatutino);
            this.groupBox1.Location = new System.Drawing.Point(295, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 92);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turno:";
            // 
            // radioButtonNoturno
            // 
            this.radioButtonNoturno.AutoSize = true;
            this.radioButtonNoturno.Location = new System.Drawing.Point(16, 64);
            this.radioButtonNoturno.Name = "radioButtonNoturno";
            this.radioButtonNoturno.Size = new System.Drawing.Size(63, 17);
            this.radioButtonNoturno.TabIndex = 7;
            this.radioButtonNoturno.TabStop = true;
            this.radioButtonNoturno.Text = "Noturno";
            this.radioButtonNoturno.UseVisualStyleBackColor = true;
            // 
            // radioButtonVespertino
            // 
            this.radioButtonVespertino.AutoSize = true;
            this.radioButtonVespertino.Location = new System.Drawing.Point(16, 41);
            this.radioButtonVespertino.Name = "radioButtonVespertino";
            this.radioButtonVespertino.Size = new System.Drawing.Size(75, 17);
            this.radioButtonVespertino.TabIndex = 6;
            this.radioButtonVespertino.TabStop = true;
            this.radioButtonVespertino.Text = "Vespertino";
            this.radioButtonVespertino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMatutino
            // 
            this.radioButtonMatutino.AutoSize = true;
            this.radioButtonMatutino.Location = new System.Drawing.Point(16, 19);
            this.radioButtonMatutino.Name = "radioButtonMatutino";
            this.radioButtonMatutino.Size = new System.Drawing.Size(66, 17);
            this.radioButtonMatutino.TabIndex = 5;
            this.radioButtonMatutino.TabStop = true;
            this.radioButtonMatutino.Text = "Matutino";
            this.radioButtonMatutino.UseVisualStyleBackColor = true;
            this.radioButtonMatutino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonCalouro);
            this.groupBox2.Controls.Add(this.radioButtonVeterano);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 47);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categoria:";
            // 
            // radioButtonCalouro
            // 
            this.radioButtonCalouro.AutoSize = true;
            this.radioButtonCalouro.Location = new System.Drawing.Point(23, 19);
            this.radioButtonCalouro.Name = "radioButtonCalouro";
            this.radioButtonCalouro.Size = new System.Drawing.Size(61, 17);
            this.radioButtonCalouro.TabIndex = 3;
            this.radioButtonCalouro.TabStop = true;
            this.radioButtonCalouro.Text = "Calouro";
            this.radioButtonCalouro.UseVisualStyleBackColor = true;
            // 
            // radioButtonVeterano
            // 
            this.radioButtonVeterano.AutoSize = true;
            this.radioButtonVeterano.Location = new System.Drawing.Point(90, 19);
            this.radioButtonVeterano.Name = "radioButtonVeterano";
            this.radioButtonVeterano.Size = new System.Drawing.Size(68, 17);
            this.radioButtonVeterano.TabIndex = 4;
            this.radioButtonVeterano.TabStop = true;
            this.radioButtonVeterano.Text = "Veterano";
            this.radioButtonVeterano.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(12, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 158);
            this.listBox1.TabIndex = 9;
            // 
            // txtSituacaoRemuneracao
            // 
            this.txtSituacaoRemuneracao.BackColor = System.Drawing.Color.Yellow;
            this.txtSituacaoRemuneracao.Enabled = false;
            this.txtSituacaoRemuneracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacaoRemuneracao.ForeColor = System.Drawing.Color.Blue;
            this.txtSituacaoRemuneracao.Location = new System.Drawing.Point(12, 323);
            this.txtSituacaoRemuneracao.Name = "txtSituacaoRemuneracao";
            this.txtSituacaoRemuneracao.Size = new System.Drawing.Size(296, 20);
            this.txtSituacaoRemuneracao.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(319, 323);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 20);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Tag = "sad ffs aas ";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 355);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSituacaoRemuneracao);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Reajuste Salarial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNoturno;
        private System.Windows.Forms.RadioButton radioButtonVespertino;
        private System.Windows.Forms.RadioButton radioButtonMatutino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonCalouro;
        private System.Windows.Forms.RadioButton radioButtonVeterano;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtSituacaoRemuneracao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

