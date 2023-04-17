namespace PMenu
{
    partial class frmExercicio4
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
            this.rtxCaracteres = new System.Windows.Forms.RichTextBox();
            this.btnCaracterNumerico = new System.Windows.Forms.Button();
            this.btnCaracterBranco = new System.Windows.Forms.Button();
            this.btnCaracterAlfabetico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxCaracteres
            // 
            this.rtxCaracteres.Location = new System.Drawing.Point(327, 92);
            this.rtxCaracteres.Name = "rtxCaracteres";
            this.rtxCaracteres.Size = new System.Drawing.Size(728, 202);
            this.rtxCaracteres.TabIndex = 0;
            this.rtxCaracteres.Text = "";
            // 
            // btnCaracterNumerico
            // 
            this.btnCaracterNumerico.Location = new System.Drawing.Point(327, 369);
            this.btnCaracterNumerico.Name = "btnCaracterNumerico";
            this.btnCaracterNumerico.Size = new System.Drawing.Size(192, 106);
            this.btnCaracterNumerico.TabIndex = 1;
            this.btnCaracterNumerico.Text = "Caracter Numérico";
            this.btnCaracterNumerico.UseVisualStyleBackColor = true;
            this.btnCaracterNumerico.Click += new System.EventHandler(this.btnCaracterNumerico_Click);
            // 
            // btnCaracterBranco
            // 
            this.btnCaracterBranco.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCaracterBranco.Location = new System.Drawing.Point(593, 369);
            this.btnCaracterBranco.Name = "btnCaracterBranco";
            this.btnCaracterBranco.Size = new System.Drawing.Size(192, 106);
            this.btnCaracterBranco.TabIndex = 2;
            this.btnCaracterBranco.Text = "Primeiro Caracter em Branco";
            this.btnCaracterBranco.UseVisualStyleBackColor = true;
            this.btnCaracterBranco.Click += new System.EventHandler(this.btnCaracterBranco_Click);
            // 
            // btnCaracterAlfabetico
            // 
            this.btnCaracterAlfabetico.Location = new System.Drawing.Point(863, 369);
            this.btnCaracterAlfabetico.Name = "btnCaracterAlfabetico";
            this.btnCaracterAlfabetico.Size = new System.Drawing.Size(192, 106);
            this.btnCaracterAlfabetico.TabIndex = 3;
            this.btnCaracterAlfabetico.Text = "Caracter Alfabético";
            this.btnCaracterAlfabetico.UseVisualStyleBackColor = true;
            this.btnCaracterAlfabetico.Click += new System.EventHandler(this.btnCaracterAlfabetico_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 629);
            this.Controls.Add(this.btnCaracterAlfabetico);
            this.Controls.Add(this.btnCaracterBranco);
            this.Controls.Add(this.btnCaracterNumerico);
            this.Controls.Add(this.rtxCaracteres);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxCaracteres;
        private System.Windows.Forms.Button btnCaracterNumerico;
        private System.Windows.Forms.Button btnCaracterBranco;
        private System.Windows.Forms.Button btnCaracterAlfabetico;
    }
}