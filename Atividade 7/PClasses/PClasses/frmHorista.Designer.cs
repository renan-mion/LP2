namespace PClasses
{
    partial class frmHorista
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
            this.btnInstancHorista = new System.Windows.Forms.Button();
            this.grpHomeOffice = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.txtSalHora = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblSalHora = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtNumHoras = new System.Windows.Forms.TextBox();
            this.lblNumHoras = new System.Windows.Forms.Label();
            this.txtNumFaltas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpHomeOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInstancHorista
            // 
            this.btnInstancHorista.Location = new System.Drawing.Point(496, 515);
            this.btnInstancHorista.Name = "btnInstancHorista";
            this.btnInstancHorista.Size = new System.Drawing.Size(461, 197);
            this.btnInstancHorista.TabIndex = 20;
            this.btnInstancHorista.Text = "Instanciar Horista";
            this.btnInstancHorista.UseVisualStyleBackColor = true;
            this.btnInstancHorista.Click += new System.EventHandler(this.BtnInstancHorista_Click);
            // 
            // grpHomeOffice
            // 
            this.grpHomeOffice.Controls.Add(this.rbtnNao);
            this.grpHomeOffice.Controls.Add(this.rbtnSim);
            this.grpHomeOffice.Location = new System.Drawing.Point(1080, 118);
            this.grpHomeOffice.Name = "grpHomeOffice";
            this.grpHomeOffice.Size = new System.Drawing.Size(308, 244);
            this.grpHomeOffice.TabIndex = 19;
            this.grpHomeOffice.TabStop = false;
            this.grpHomeOffice.Text = "Trabalha em Home Office?";
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(46, 145);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(69, 29);
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
            this.rbtnSim.Size = new System.Drawing.Size(66, 29);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(356, 329);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(186, 31);
            this.txtDataEntrada.TabIndex = 18;
            // 
            // txtSalHora
            // 
            this.txtSalHora.Location = new System.Drawing.Point(356, 194);
            this.txtSalHora.Name = "txtSalHora";
            this.txtSalHora.Size = new System.Drawing.Size(186, 31);
            this.txtSalHora.TabIndex = 17;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(356, 123);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(602, 31);
            this.txtNome.TabIndex = 16;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(356, 49);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(186, 31);
            this.txtMatricula.TabIndex = 15;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(70, 332);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(259, 25);
            this.lblDataEntrada.TabIndex = 14;
            this.lblDataEntrada.Text = "Data Entrada na Empresa";
            // 
            // lblSalHora
            // 
            this.lblSalHora.AutoSize = true;
            this.lblSalHora.Location = new System.Drawing.Point(70, 200);
            this.lblSalHora.Name = "lblSalHora";
            this.lblSalHora.Size = new System.Drawing.Size(168, 25);
            this.lblSalHora.TabIndex = 13;
            this.lblSalHora.Text = "Salário por Hora";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(70, 127);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 25);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(70, 55);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(100, 25);
            this.lblMatricula.TabIndex = 11;
            this.lblMatricula.Text = "Matricula";
            // 
            // txtNumHoras
            // 
            this.txtNumHoras.Location = new System.Drawing.Point(356, 263);
            this.txtNumHoras.Name = "txtNumHoras";
            this.txtNumHoras.Size = new System.Drawing.Size(186, 31);
            this.txtNumHoras.TabIndex = 23;
            // 
            // lblNumHoras
            // 
            this.lblNumHoras.AutoSize = true;
            this.lblNumHoras.Location = new System.Drawing.Point(70, 266);
            this.lblNumHoras.Name = "lblNumHoras";
            this.lblNumHoras.Size = new System.Drawing.Size(177, 25);
            this.lblNumHoras.TabIndex = 22;
            this.lblNumHoras.Text = "Número de horas";
            // 
            // txtNumFaltas
            // 
            this.txtNumFaltas.Location = new System.Drawing.Point(356, 401);
            this.txtNumFaltas.Name = "txtNumFaltas";
            this.txtNumFaltas.Size = new System.Drawing.Size(186, 31);
            this.txtNumFaltas.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Número de faltas";
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 829);
            this.Controls.Add(this.txtNumFaltas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumHoras);
            this.Controls.Add(this.lblNumHoras);
            this.Controls.Add(this.btnInstancHorista);
            this.Controls.Add(this.grpHomeOffice);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.txtSalHora);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblSalHora);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.Load += new System.EventHandler(this.FrmHorista_Load);
            this.grpHomeOffice.ResumeLayout(false);
            this.grpHomeOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstancHorista;
        private System.Windows.Forms.GroupBox grpHomeOffice;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.TextBox txtSalHora;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblSalHora;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtNumHoras;
        private System.Windows.Forms.Label lblNumHoras;
        private System.Windows.Forms.TextBox txtNumFaltas;
        private System.Windows.Forms.Label label1;
    }
}