namespace PClasses
{
    partial class frmMensalista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalMensal = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalMensal = new System.Windows.Forms.TextBox();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.grpHomeOffice = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.btnInstancMensal = new System.Windows.Forms.Button();
            this.btnInstancMensalParametro = new System.Windows.Forms.Button();
            this.grpHomeOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(69, 142);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(85, 24);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(69, 214);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 24);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalMensal
            // 
            this.lblSalMensal.AutoSize = true;
            this.lblSalMensal.Location = new System.Drawing.Point(69, 287);
            this.lblSalMensal.Name = "lblSalMensal";
            this.lblSalMensal.Size = new System.Drawing.Size(133, 24);
            this.lblSalMensal.TabIndex = 2;
            this.lblSalMensal.Text = "Salário Mensal";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(69, 357);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(224, 24);
            this.lblDataEntrada.TabIndex = 3;
            this.lblDataEntrada.Text = "Data Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(315, 137);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(186, 29);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(315, 211);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(602, 29);
            this.txtNome.TabIndex = 5;
            // 
            // txtSalMensal
            // 
            this.txtSalMensal.Location = new System.Drawing.Point(315, 282);
            this.txtSalMensal.Name = "txtSalMensal";
            this.txtSalMensal.Size = new System.Drawing.Size(186, 29);
            this.txtSalMensal.TabIndex = 6;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(315, 352);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(186, 29);
            this.txtDataEntrada.TabIndex = 7;
            // 
            // grpHomeOffice
            // 
            this.grpHomeOffice.Controls.Add(this.rbtnNao);
            this.grpHomeOffice.Controls.Add(this.rbtnSim);
            this.grpHomeOffice.Location = new System.Drawing.Point(1080, 137);
            this.grpHomeOffice.Name = "grpHomeOffice";
            this.grpHomeOffice.Size = new System.Drawing.Size(308, 244);
            this.grpHomeOffice.TabIndex = 8;
            this.grpHomeOffice.TabStop = false;
            this.grpHomeOffice.Text = "Trabalha em Home Office?";
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(46, 145);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(63, 28);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(46, 74);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(60, 28);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // btnInstancMensal
            // 
            this.btnInstancMensal.Location = new System.Drawing.Point(192, 532);
            this.btnInstancMensal.Name = "btnInstancMensal";
            this.btnInstancMensal.Size = new System.Drawing.Size(461, 197);
            this.btnInstancMensal.TabIndex = 9;
            this.btnInstancMensal.Text = "Instanciar Mensalista";
            this.btnInstancMensal.UseVisualStyleBackColor = true;
            this.btnInstancMensal.Click += new System.EventHandler(this.BtnInstancMensal_Click);
            // 
            // btnInstancMensalParametro
            // 
            this.btnInstancMensalParametro.Location = new System.Drawing.Point(823, 532);
            this.btnInstancMensalParametro.Name = "btnInstancMensalParametro";
            this.btnInstancMensalParametro.Size = new System.Drawing.Size(461, 197);
            this.btnInstancMensalParametro.TabIndex = 10;
            this.btnInstancMensalParametro.Text = "Instanciar Mensalista passando parâmetro";
            this.btnInstancMensalParametro.UseVisualStyleBackColor = true;
            this.btnInstancMensalParametro.Click += new System.EventHandler(this.BtnInstancMensalParametro_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 843);
            this.Controls.Add(this.btnInstancMensalParametro);
            this.Controls.Add(this.btnInstancMensal);
            this.Controls.Add(this.grpHomeOffice);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.txtSalMensal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblSalMensal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.grpHomeOffice.ResumeLayout(false);
            this.grpHomeOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalMensal;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalMensal;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.GroupBox grpHomeOffice;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.Button btnInstancMensal;
        private System.Windows.Forms.Button btnInstancMensalParametro;
    }
}