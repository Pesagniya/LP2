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
            this.btnSpace = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnPair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(40, 33);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(280, 354);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnSpace
            // 
            this.btnSpace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpace.Location = new System.Drawing.Point(458, 124);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(168, 45);
            this.btnSpace.TabIndex = 1;
            this.btnSpace.Text = "Número de espaços";
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.BtnSpace_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(458, 175);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(168, 45);
            this.btnR.TabIndex = 2;
            this.btnR.Text = "Número de \"R\"";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.BtnR_Click);
            // 
            // btnPair
            // 
            this.btnPair.Location = new System.Drawing.Point(458, 226);
            this.btnPair.Name = "btnPair";
            this.btnPair.Size = new System.Drawing.Size(168, 45);
            this.btnPair.TabIndex = 3;
            this.btnPair.Text = "Número de pares de letras";
            this.btnPair.UseVisualStyleBackColor = true;
            this.btnPair.Click += new System.EventHandler(this.BtnPair_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPair);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnPair;
    }
}