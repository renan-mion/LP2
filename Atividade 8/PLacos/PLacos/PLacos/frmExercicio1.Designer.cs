namespace PLacos
{
    partial class frmExercicio1
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnEspacosEmBranco = new System.Windows.Forms.Button();
            this.btnNumeroDeRs = new System.Windows.Forms.Button();
            this.btnParDeLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(350, 64);
            this.rchtxtFrase.MaxLength = 100;
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(675, 254);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnEspacosEmBranco
            // 
            this.btnEspacosEmBranco.Location = new System.Drawing.Point(211, 440);
            this.btnEspacosEmBranco.Name = "btnEspacosEmBranco";
            this.btnEspacosEmBranco.Size = new System.Drawing.Size(233, 117);
            this.btnEspacosEmBranco.TabIndex = 1;
            this.btnEspacosEmBranco.Text = "Espaços em branco";
            this.btnEspacosEmBranco.UseVisualStyleBackColor = true;
            this.btnEspacosEmBranco.Click += new System.EventHandler(this.BtnEspacosEmBranco_Click);
            // 
            // btnNumeroDeRs
            // 
            this.btnNumeroDeRs.Location = new System.Drawing.Point(574, 440);
            this.btnNumeroDeRs.Name = "btnNumeroDeRs";
            this.btnNumeroDeRs.Size = new System.Drawing.Size(233, 117);
            this.btnNumeroDeRs.TabIndex = 2;
            this.btnNumeroDeRs.Text = "Número de letras R";
            this.btnNumeroDeRs.UseVisualStyleBackColor = true;
            this.btnNumeroDeRs.Click += new System.EventHandler(this.BtnNumeroDeRs_Click);
            // 
            // btnParDeLetras
            // 
            this.btnParDeLetras.Location = new System.Drawing.Point(934, 440);
            this.btnParDeLetras.Name = "btnParDeLetras";
            this.btnParDeLetras.Size = new System.Drawing.Size(233, 117);
            this.btnParDeLetras.TabIndex = 3;
            this.btnParDeLetras.Text = "Número de pares de letras";
            this.btnParDeLetras.UseVisualStyleBackColor = true;
            this.btnParDeLetras.Click += new System.EventHandler(this.BtnParDeLetras_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 641);
            this.Controls.Add(this.btnParDeLetras);
            this.Controls.Add(this.btnNumeroDeRs);
            this.Controls.Add(this.btnEspacosEmBranco);
            this.Controls.Add(this.rchtxtFrase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnEspacosEmBranco;
        private System.Windows.Forms.Button btnNumeroDeRs;
        private System.Windows.Forms.Button btnParDeLetras;
    }
}