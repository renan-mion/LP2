namespace PLacos
{
    partial class frmExercicio3
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
            this.btnPalindromo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalindromo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPalindromo
            // 
            this.btnPalindromo.Location = new System.Drawing.Point(332, 257);
            this.btnPalindromo.Name = "btnPalindromo";
            this.btnPalindromo.Size = new System.Drawing.Size(225, 61);
            this.btnPalindromo.TabIndex = 1;
            this.btnPalindromo.Text = "É Palíndromo?";
            this.btnPalindromo.UseVisualStyleBackColor = true;
            this.btnPalindromo.Click += new System.EventHandler(this.btnPalindromo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite uma palavra";
            // 
            // txtPalindromo
            // 
            this.txtPalindromo.Location = new System.Drawing.Point(116, 187);
            this.txtPalindromo.Name = "txtPalindromo";
            this.txtPalindromo.Size = new System.Drawing.Size(700, 29);
            this.txtPalindromo.TabIndex = 3;
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 475);
            this.Controls.Add(this.txtPalindromo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPalindromo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPalindromo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalindromo;
    }
}