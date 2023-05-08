namespace PLacos
{
    partial class frmExercicio2
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnGerarH = new System.Windows.Forms.Button();
            this.lblN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(507, 284);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(392, 29);
            this.txtNumero.TabIndex = 0;
            // 
            // btnGerarH
            // 
            this.btnGerarH.Location = new System.Drawing.Point(482, 432);
            this.btnGerarH.Name = "btnGerarH";
            this.btnGerarH.Size = new System.Drawing.Size(443, 153);
            this.btnGerarH.TabIndex = 1;
            this.btnGerarH.Text = "Gerar H";
            this.btnGerarH.UseVisualStyleBackColor = true;
            this.btnGerarH.Click += new System.EventHandler(this.BtnGerarH_Click);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(626, 212);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(168, 24);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "Digite o número N:";
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 819);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.btnGerarH);
            this.Controls.Add(this.txtNumero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnGerarH;
        private System.Windows.Forms.Label lblN;
    }
}