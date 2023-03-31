namespace PSalario
{
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
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.nudNumFilhos = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.pnlCasado = new System.Windows.Forms.Panel();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescINSS = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.txtAliqIRPF = new System.Windows.Forms.TextBox();
            this.txtAliqINSS = new System.Windows.Forms.TextBox();
            this.txtDescIRPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAliqINSS = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVerifDesconto = new System.Windows.Forms.Button();
            this.lblDados = new System.Windows.Forms.Label();
            this.mskbxSalLiquido = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumFilhos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlCasado.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalBruto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mskbxSalBruto.Location = new System.Drawing.Point(200, 61);
            this.mskbxSalBruto.Margin = new System.Windows.Forms.Padding(2);
            this.mskbxSalBruto.Mask = "99990.00";
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(207, 31);
            this.mskbxSalBruto.TabIndex = 0;
            // 
            // nudNumFilhos
            // 
            this.nudNumFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumFilhos.Location = new System.Drawing.Point(200, 111);
            this.nudNumFilhos.Margin = new System.Windows.Forms.Padding(2);
            this.nudNumFilhos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumFilhos.Name = "nudNumFilhos";
            this.nudNumFilhos.Size = new System.Drawing.Size(207, 31);
            this.nudNumFilhos.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMasc);
            this.groupBox1.Controls.Add(this.rbtnFem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(581, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(146, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(27, 42);
            this.rbtnMasc.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(44, 28);
            this.rbtnMasc.TabIndex = 1;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "M";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(27, 19);
            this.rbtnFem.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(40, 28);
            this.rbtnFem.TabIndex = 0;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "F";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // pnlCasado
            // 
            this.pnlCasado.Controls.Add(this.ckbxCasado);
            this.pnlCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCasado.Location = new System.Drawing.Point(581, 170);
            this.pnlCasado.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCasado.Name = "pnlCasado";
            this.pnlCasado.Size = new System.Drawing.Size(146, 67);
            this.pnlCasado.TabIndex = 3;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(35, 26);
            this.ckbxCasado.Margin = new System.Windows.Forms.Padding(2);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(93, 28);
            this.ckbxCasado.TabIndex = 0;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFunc.Location = new System.Drawing.Point(17, 19);
            this.lblNomeFunc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(187, 25);
            this.lblNomeFunc.TabIndex = 4;
            this.lblNomeFunc.Text = "Nome Funcionário";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBruto.Location = new System.Drawing.Point(16, 67);
            this.lblSalBruto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(136, 25);
            this.lblSalBruto.TabIndex = 5;
            this.lblSalBruto.Text = "Salário Bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFilhos.Location = new System.Drawing.Point(14, 111);
            this.lblNumFilhos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(181, 25);
            this.lblNumFilhos.TabIndex = 6;
            this.lblNumFilhos.Text = "Número de Filhos";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(201, 13);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(206, 31);
            this.txtNome.TabIndex = 7;
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Enabled = false;
            this.txtDescINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescINSS.Location = new System.Drawing.Point(672, 295);
            this.txtDescINSS.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.ReadOnly = true;
            this.txtDescINSS.Size = new System.Drawing.Size(206, 29);
            this.txtDescINSS.TabIndex = 10;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Enabled = false;
            this.txtSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalFamilia.Location = new System.Drawing.Point(200, 358);
            this.txtSalFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.ReadOnly = true;
            this.txtSalFamilia.Size = new System.Drawing.Size(206, 31);
            this.txtSalFamilia.TabIndex = 12;
            // 
            // txtAliqIRPF
            // 
            this.txtAliqIRPF.Enabled = false;
            this.txtAliqIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliqIRPF.Location = new System.Drawing.Point(200, 323);
            this.txtAliqIRPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtAliqIRPF.Name = "txtAliqIRPF";
            this.txtAliqIRPF.ReadOnly = true;
            this.txtAliqIRPF.Size = new System.Drawing.Size(206, 31);
            this.txtAliqIRPF.TabIndex = 13;
            // 
            // txtAliqINSS
            // 
            this.txtAliqINSS.Enabled = false;
            this.txtAliqINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliqINSS.Location = new System.Drawing.Point(200, 286);
            this.txtAliqINSS.Margin = new System.Windows.Forms.Padding(2);
            this.txtAliqINSS.Name = "txtAliqINSS";
            this.txtAliqINSS.ReadOnly = true;
            this.txtAliqINSS.Size = new System.Drawing.Size(206, 31);
            this.txtAliqINSS.TabIndex = 14;
            // 
            // txtDescIRPF
            // 
            this.txtDescIRPF.Enabled = false;
            this.txtDescIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescIRPF.Location = new System.Drawing.Point(672, 333);
            this.txtDescIRPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescIRPF.Name = "txtDescIRPF";
            this.txtDescIRPF.ReadOnly = true;
            this.txtDescIRPF.Size = new System.Drawing.Size(206, 29);
            this.txtDescIRPF.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Salário Família";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 327);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "AlíquotaIRPF";
            // 
            // lblAliqINSS
            // 
            this.lblAliqINSS.AutoSize = true;
            this.lblAliqINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliqINSS.Location = new System.Drawing.Point(17, 290);
            this.lblAliqINSS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAliqINSS.Name = "lblAliqINSS";
            this.lblAliqINSS.Size = new System.Drawing.Size(144, 25);
            this.lblAliqINSS.TabIndex = 16;
            this.lblAliqINSS.Text = "Alíquota INSS";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescINSS.Location = new System.Drawing.Point(508, 299);
            this.lblDescINSS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(137, 24);
            this.lblDescINSS.TabIndex = 21;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescIRPF.Location = new System.Drawing.Point(509, 336);
            this.lblDescIRPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(136, 24);
            this.lblDescIRPF.TabIndex = 20;
            this.lblDescIRPF.Text = "Desconto IRPF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 395);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Salário Líquido";
            // 
            // btnVerifDesconto
            // 
            this.btnVerifDesconto.Location = new System.Drawing.Point(201, 170);
            this.btnVerifDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerifDesconto.Name = "btnVerifDesconto";
            this.btnVerifDesconto.Size = new System.Drawing.Size(205, 50);
            this.btnVerifDesconto.TabIndex = 22;
            this.btnVerifDesconto.Text = "Verificar Desconto";
            this.btnVerifDesconto.UseVisualStyleBackColor = true;
            this.btnVerifDesconto.Click += new System.EventHandler(this.BtnVerifDesconto_Click);
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(18, 237);
            this.lblDados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(63, 16);
            this.lblDados.TabIndex = 23;
            this.lblDados.Text = "lblDados";
            // 
            // mskbxSalLiquido
            // 
            this.mskbxSalLiquido.Enabled = false;
            this.mskbxSalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalLiquido.Location = new System.Drawing.Point(200, 395);
            this.mskbxSalLiquido.Margin = new System.Windows.Forms.Padding(2);
            this.mskbxSalLiquido.Mask = "99990.00";
            this.mskbxSalLiquido.Name = "mskbxSalLiquido";
            this.mskbxSalLiquido.ReadOnly = true;
            this.mskbxSalLiquido.ResetOnSpace = false;
            this.mskbxSalLiquido.Size = new System.Drawing.Size(206, 31);
            this.mskbxSalLiquido.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 521);
            this.Controls.Add(this.mskbxSalLiquido);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.btnVerifDesconto);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAliqINSS);
            this.Controls.Add(this.txtDescIRPF);
            this.Controls.Add(this.txtAliqINSS);
            this.Controls.Add(this.txtAliqIRPF);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtDescINSS);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNomeFunc);
            this.Controls.Add(this.pnlCasado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudNumFilhos);
            this.Controls.Add(this.mskbxSalBruto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumFilhos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlCasado.ResumeLayout(false);
            this.pnlCasado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.NumericUpDown nudNumFilhos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlCasado;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescINSS;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.TextBox txtAliqIRPF;
        private System.Windows.Forms.TextBox txtAliqINSS;
        private System.Windows.Forms.TextBox txtDescIRPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAliqINSS;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.Button btnVerifDesconto;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.MaskedTextBox mskbxSalLiquido;
    }
}

