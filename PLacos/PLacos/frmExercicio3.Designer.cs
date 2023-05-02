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
            this.btnChecar = new System.Windows.Forms.Button();
            this.txtPalindromo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChecar
            // 
            this.btnChecar.Location = new System.Drawing.Point(194, 157);
            this.btnChecar.Name = "btnChecar";
            this.btnChecar.Size = new System.Drawing.Size(118, 91);
            this.btnChecar.TabIndex = 0;
            this.btnChecar.Text = "A palavra inserida é um palíndromo?";
            this.btnChecar.UseVisualStyleBackColor = true;
            this.btnChecar.Click += new System.EventHandler(this.BtnChecar_Click);
            // 
            // txtPalindromo
            // 
            this.txtPalindromo.Location = new System.Drawing.Point(354, 193);
            this.txtPalindromo.Name = "txtPalindromo";
            this.txtPalindromo.Size = new System.Drawing.Size(311, 20);
            this.txtPalindromo.TabIndex = 1;
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPalindromo);
            this.Controls.Add(this.btnChecar);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChecar;
        private System.Windows.Forms.TextBox txtPalindromo;
    }
}