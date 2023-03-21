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
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.radioButtonNoturno = new System.Windows.Forms.RadioButton();
            this.radioButtonVespertino = new System.Windows.Forms.RadioButton();
            this.radioButtonMatutino = new System.Windows.Forms.RadioButton();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.radioButtonCalouro = new System.Windows.Forms.RadioButton();
            this.radioButtonVeterano = new System.Windows.Forms.RadioButton();
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.txtSituacaoEstagiario = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.gbxTurno.SuspendLayout();
            this.gbxCategoria.SuspendLayout();
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
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
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
            this.toolTip1.SetToolTip(this.txtSalarioMinimo, "Informe o Salário Mínimo");
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
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.radioButtonNoturno);
            this.gbxTurno.Controls.Add(this.radioButtonVespertino);
            this.gbxTurno.Controls.Add(this.radioButtonMatutino);
            this.gbxTurno.Location = new System.Drawing.Point(295, 46);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(99, 92);
            this.gbxTurno.TabIndex = 5;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno:";
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
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.radioButtonCalouro);
            this.gbxCategoria.Controls.Add(this.radioButtonVeterano);
            this.gbxCategoria.Location = new System.Drawing.Point(12, 102);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(185, 47);
            this.gbxCategoria.TabIndex = 6;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria:";
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
            // lbxResumo
            // 
            this.lbxResumo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.ItemHeight = 14;
            this.lbxResumo.Location = new System.Drawing.Point(12, 155);
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.Size = new System.Drawing.Size(382, 158);
            this.lbxResumo.TabIndex = 9;
            // 
            // txtSituacaoEstagiario
            // 
            this.txtSituacaoEstagiario.BackColor = System.Drawing.Color.Yellow;
            this.txtSituacaoEstagiario.Enabled = false;
            this.txtSituacaoEstagiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacaoEstagiario.ForeColor = System.Drawing.Color.Blue;
            this.txtSituacaoEstagiario.Location = new System.Drawing.Point(12, 323);
            this.txtSituacaoEstagiario.Name = "txtSituacaoEstagiario";
            this.txtSituacaoEstagiario.Size = new System.Drawing.Size(296, 20);
            this.txtSituacaoEstagiario.TabIndex = 8;
            this.txtSituacaoEstagiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(319, 323);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 20);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 355);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSituacaoEstagiario);
            this.Controls.Add(this.lbxResumo);
            this.Controls.Add(this.gbxCategoria);
            this.Controls.Add(this.gbxTurno);
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
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.RadioButton radioButtonNoturno;
        private System.Windows.Forms.RadioButton radioButtonVespertino;
        private System.Windows.Forms.RadioButton radioButtonMatutino;
        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.RadioButton radioButtonCalouro;
        private System.Windows.Forms.RadioButton radioButtonVeterano;
        private System.Windows.Forms.ListBox lbxResumo;
        private System.Windows.Forms.TextBox txtSituacaoEstagiario;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

