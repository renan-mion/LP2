namespace IMC
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(107, 163);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(68, 25);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 537);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(208, 85);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(499, 537);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(226, 85);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(259, 160);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(392, 31);
            this.txtAltura.TabIndex = 4;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(107, 248);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(61, 25);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(259, 239);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(6);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(392, 31);
            this.txtPeso.TabIndex = 5;
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(259, 302);
            this.txtIMC.Margin = new System.Windows.Forms.Padding(6);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.ReadOnly = true;
            this.txtIMC.Size = new System.Drawing.Size(392, 31);
            this.txtIMC.TabIndex = 7;
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Enabled = false;
            this.lblIMC.Location = new System.Drawing.Point(107, 308);
            this.lblIMC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(50, 25);
            this.lblIMC.TabIndex = 6;
            this.lblIMC.Text = "IMC";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(259, 537);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(6);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(208, 85);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(259, 363);
            this.txtClasse.Margin = new System.Windows.Forms.Padding(6);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.ReadOnly = true;
            this.txtClasse.Size = new System.Drawing.Size(392, 31);
            this.txtClasse.TabIndex = 10;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Enabled = false;
            this.lblClass.Location = new System.Drawing.Point(107, 366);
            this.lblClass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(140, 25);
            this.lblClass.TabIndex = 9;
            this.lblClass.Text = "Classificação";
            //this.lblClass.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 661);
            this.Controls.Add(this.txtClasse);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.Label lblClass;
    }
}

