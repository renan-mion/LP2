namespace PMenu
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
            this.btnTrasPraFrente = new System.Windows.Forms.Button();
            this.btnRemoveReplace = new System.Windows.Forms.Button();
            this.btnRemoveIndexOf = new System.Windows.Forms.Button();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrasPraFrente
            // 
            this.btnTrasPraFrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasPraFrente.Location = new System.Drawing.Point(867, 457);
            this.btnTrasPraFrente.Name = "btnTrasPraFrente";
            this.btnTrasPraFrente.Size = new System.Drawing.Size(204, 86);
            this.btnTrasPraFrente.TabIndex = 13;
            this.btnTrasPraFrente.Text = "Trás pra frente";
            this.btnTrasPraFrente.UseVisualStyleBackColor = true;
            this.btnTrasPraFrente.Click += new System.EventHandler(this.BtnTrasPraFrente_Click);
            // 
            // btnRemoveReplace
            // 
            this.btnRemoveReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveReplace.Location = new System.Drawing.Point(615, 457);
            this.btnRemoveReplace.Name = "btnRemoveReplace";
            this.btnRemoveReplace.Size = new System.Drawing.Size(204, 86);
            this.btnRemoveReplace.TabIndex = 12;
            this.btnRemoveReplace.Text = "Remove (replace)";
            this.btnRemoveReplace.UseVisualStyleBackColor = true;
            this.btnRemoveReplace.Click += new System.EventHandler(this.BtnRemoveReplace_Click);
            // 
            // btnRemoveIndexOf
            // 
            this.btnRemoveIndexOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveIndexOf.Location = new System.Drawing.Point(366, 457);
            this.btnRemoveIndexOf.Name = "btnRemoveIndexOf";
            this.btnRemoveIndexOf.Size = new System.Drawing.Size(204, 86);
            this.btnRemoveIndexOf.TabIndex = 11;
            this.btnRemoveIndexOf.Text = "Remove (IndexOf)";
            this.btnRemoveIndexOf.UseVisualStyleBackColor = true;
            this.btnRemoveIndexOf.Click += new System.EventHandler(this.BtnRemoveIndexOf_Click);
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(556, 322);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(6);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(379, 31);
            this.txtPalavra2.TabIndex = 10;
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(556, 218);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(6);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(379, 31);
            this.txtPalavra1.TabIndex = 9;
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(400, 322);
            this.lblPalavra2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(97, 25);
            this.lblPalavra2.TabIndex = 8;
            this.lblPalavra2.Text = "Palavra2";
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(400, 218);
            this.lblPalavra1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(97, 25);
            this.lblPalavra1.TabIndex = 7;
            this.lblPalavra1.Text = "Palavra1";
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 760);
            this.Controls.Add(this.btnTrasPraFrente);
            this.Controls.Add(this.btnRemoveReplace);
            this.Controls.Add(this.btnRemoveIndexOf);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrasPraFrente;
        private System.Windows.Forms.Button btnRemoveReplace;
        private System.Windows.Forms.Button btnRemoveIndexOf;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Label lblPalavra1;
    }
}