partial class Form1
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
        this.nrCasa = new System.Windows.Forms.Label();
        this.txtNrCasa = new System.Windows.Forms.TextBox();
        this.txtConsumo = new System.Windows.Forms.TextBox();
        this.lblConsumo = new System.Windows.Forms.Label();
        this.btnRegistrar = new System.Windows.Forms.Button();
        this.dgvLeituras = new System.Windows.Forms.DataGridView();
        this.btnProcessar = new System.Windows.Forms.Button();
        this.lblTotalConsumoSemDesconto = new System.Windows.Forms.Label();
        this.lblTotalConsumoSemDesc = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).BeginInit();
        this.SuspendLayout();
        // 
        // nrCasa
        // 
        this.nrCasa.AutoSize = true;
        this.nrCasa.Location = new System.Drawing.Point(12, 13);
        this.nrCasa.Name = "nrCasa";
        this.nrCasa.Size = new System.Drawing.Size(51, 13);
        this.nrCasa.TabIndex = 0;
        this.nrCasa.Text = "Nr. Casa:";
        // 
        // txtNrCasa
        // 
        this.txtNrCasa.Location = new System.Drawing.Point(66, 8);
        this.txtNrCasa.Name = "txtNrCasa";
        this.txtNrCasa.Size = new System.Drawing.Size(100, 20);
        this.txtNrCasa.TabIndex = 1;
        // 
        // txtConsumo
        // 
        this.txtConsumo.Location = new System.Drawing.Point(261, 6);
        this.txtConsumo.Name = "txtConsumo";
        this.txtConsumo.Size = new System.Drawing.Size(100, 20);
        this.txtConsumo.TabIndex = 3;
        this.txtConsumo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
        // 
        // lblConsumo
        // 
        this.lblConsumo.AutoSize = true;
        this.lblConsumo.Location = new System.Drawing.Point(204, 13);
        this.lblConsumo.Name = "lblConsumo";
        this.lblConsumo.Size = new System.Drawing.Size(54, 13);
        this.lblConsumo.TabIndex = 2;
        this.lblConsumo.Text = "Consumo:";
        // 
        // btnRegistrar
        // 
        this.btnRegistrar.Location = new System.Drawing.Point(395, 6);
        this.btnRegistrar.Name = "btnRegistrar";
        this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
        this.btnRegistrar.TabIndex = 4;
        this.btnRegistrar.Text = "Registrar";
        this.btnRegistrar.UseVisualStyleBackColor = true;
        this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
        // 
        // dgvLeituras
        // 
        this.dgvLeituras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvLeituras.Location = new System.Drawing.Point(15, 54);
        this.dgvLeituras.Name = "dgvLeituras";
        this.dgvLeituras.Size = new System.Drawing.Size(455, 192);
        this.dgvLeituras.TabIndex = 5;
        // 
        // btnProcessar
        // 
        this.btnProcessar.Location = new System.Drawing.Point(15, 263);
        this.btnProcessar.Name = "btnProcessar";
        this.btnProcessar.Size = new System.Drawing.Size(75, 23);
        this.btnProcessar.TabIndex = 6;
        this.btnProcessar.Text = "Processar";
        this.btnProcessar.UseVisualStyleBackColor = true;
        this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
        // 
        // lblTotalConsumoSemDesconto
        // 
        this.lblTotalConsumoSemDesconto.AutoSize = true;
        this.lblTotalConsumoSemDesconto.Location = new System.Drawing.Point(219, 273);
        this.lblTotalConsumoSemDesconto.Name = "lblTotalConsumoSemDesconto";
        this.lblTotalConsumoSemDesconto.Size = new System.Drawing.Size(151, 13);
        this.lblTotalConsumoSemDesconto.TabIndex = 7;
        this.lblTotalConsumoSemDesconto.Text = "Total Consumo Sem Desconto";
        // 
        // lblTotalConsumoSemDesc
        // 
        this.lblTotalConsumoSemDesc.AutoSize = true;
        this.lblTotalConsumoSemDesc.Location = new System.Drawing.Point(392, 273);
        this.lblTotalConsumoSemDesc.Name = "lblTotalConsumoSemDesc";
        this.lblTotalConsumoSemDesc.Size = new System.Drawing.Size(0, 13);
        this.lblTotalConsumoSemDesc.TabIndex = 8;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(489, 313);
        this.Controls.Add(this.lblTotalConsumoSemDesc);
        this.Controls.Add(this.lblTotalConsumoSemDesconto);
        this.Controls.Add(this.btnProcessar);
        this.Controls.Add(this.dgvLeituras);
        this.Controls.Add(this.btnRegistrar);
        this.Controls.Add(this.txtConsumo);
        this.Controls.Add(this.lblConsumo);
        this.Controls.Add(this.txtNrCasa);
        this.Controls.Add(this.nrCasa);
        this.Name = "Form1";
        this.Text = "Form1";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label nrCasa;
    private System.Windows.Forms.TextBox txtNrCasa;
    private System.Windows.Forms.TextBox txtConsumo;
    private System.Windows.Forms.Label lblConsumo;
    private System.Windows.Forms.Button btnRegistrar;
    private System.Windows.Forms.DataGridView dgvLeituras;
    private System.Windows.Forms.Button btnProcessar;
    private System.Windows.Forms.Label lblTotalConsumoSemDesconto;
    private System.Windows.Forms.Label lblTotalConsumoSemDesc;
}
}