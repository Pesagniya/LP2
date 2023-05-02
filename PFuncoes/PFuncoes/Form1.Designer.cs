namespace PFuncoes
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
            this.btnSoma1 = new System.Windows.Forms.Button();
            this.btnSoma2 = new System.Windows.Forms.Button();
            this.btnSoma3 = new System.Windows.Forms.Button();
            this.btnSoma4 = new System.Windows.Forms.Button();
            this.btnSoma5 = new System.Windows.Forms.Button();
            this.btnSoma6 = new System.Windows.Forms.Button();
            this.btnSoma7 = new System.Windows.Forms.Button();
            this.btnSoma8 = new System.Windows.Forms.Button();
            this.btnSoma9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoma1
            // 
            this.btnSoma1.Location = new System.Drawing.Point(182, 87);
            this.btnSoma1.Name = "btnSoma1";
            this.btnSoma1.Size = new System.Drawing.Size(115, 71);
            this.btnSoma1.TabIndex = 0;
            this.btnSoma1.Text = "Função Void";
            this.btnSoma1.UseVisualStyleBackColor = true;
            this.btnSoma1.Click += new System.EventHandler(this.BtnSoma1_Click);
            // 
            // btnSoma2
            // 
            this.btnSoma2.Location = new System.Drawing.Point(182, 177);
            this.btnSoma2.Name = "btnSoma2";
            this.btnSoma2.Size = new System.Drawing.Size(115, 71);
            this.btnSoma2.TabIndex = 1;
            this.btnSoma2.Text = "Função com resultado";
            this.btnSoma2.UseVisualStyleBackColor = true;
            this.btnSoma2.Click += new System.EventHandler(this.BtnSoma2_Click);
            // 
            // btnSoma3
            // 
            this.btnSoma3.Location = new System.Drawing.Point(182, 266);
            this.btnSoma3.Name = "btnSoma3";
            this.btnSoma3.Size = new System.Drawing.Size(115, 71);
            this.btnSoma3.TabIndex = 2;
            this.btnSoma3.Text = "Função Void com parâmetros";
            this.btnSoma3.UseVisualStyleBackColor = true;
            this.btnSoma3.Click += new System.EventHandler(this.BtnSoma3_Click);
            // 
            // btnSoma4
            // 
            this.btnSoma4.Location = new System.Drawing.Point(339, 87);
            this.btnSoma4.Name = "btnSoma4";
            this.btnSoma4.Size = new System.Drawing.Size(115, 71);
            this.btnSoma4.TabIndex = 3;
            this.btnSoma4.Text = "Função com Retorno e parâmetros";
            this.btnSoma4.UseVisualStyleBackColor = true;
            this.btnSoma4.Click += new System.EventHandler(this.BtnSoma4_Click);
            // 
            // btnSoma5
            // 
            this.btnSoma5.Location = new System.Drawing.Point(339, 177);
            this.btnSoma5.Name = "btnSoma5";
            this.btnSoma5.Size = new System.Drawing.Size(115, 71);
            this.btnSoma5.TabIndex = 4;
            this.btnSoma5.Text = "Função Void com parâmetros por referência";
            this.btnSoma5.UseVisualStyleBackColor = true;
            this.btnSoma5.Click += new System.EventHandler(this.BtnSoma5_Click);
            // 
            // btnSoma6
            // 
            this.btnSoma6.Location = new System.Drawing.Point(339, 266);
            this.btnSoma6.Name = "btnSoma6";
            this.btnSoma6.Size = new System.Drawing.Size(115, 71);
            this.btnSoma6.TabIndex = 5;
            this.btnSoma6.Text = "Função Void com Retorno e com parâmetros por referência";
            this.btnSoma6.UseVisualStyleBackColor = true;
            this.btnSoma6.Click += new System.EventHandler(this.BtnSoma6_Click);
            // 
            // btnSoma7
            // 
            this.btnSoma7.Location = new System.Drawing.Point(490, 87);
            this.btnSoma7.Name = "btnSoma7";
            this.btnSoma7.Size = new System.Drawing.Size(115, 71);
            this.btnSoma7.TabIndex = 6;
            this.btnSoma7.Text = "Função Void com parâmetro de saída";
            this.btnSoma7.UseVisualStyleBackColor = true;
            this.btnSoma7.Click += new System.EventHandler(this.BtnSoma7_Click);
            // 
            // btnSoma8
            // 
            this.btnSoma8.Location = new System.Drawing.Point(490, 177);
            this.btnSoma8.Name = "btnSoma8";
            this.btnSoma8.Size = new System.Drawing.Size(115, 71);
            this.btnSoma8.TabIndex = 7;
            this.btnSoma8.Text = "Função Void com retorno e com parâmetro de saída";
            this.btnSoma8.UseVisualStyleBackColor = true;
            this.btnSoma8.Click += new System.EventHandler(this.BtnSoma8_Click);
            // 
            // btnSoma9
            // 
            this.btnSoma9.Location = new System.Drawing.Point(490, 266);
            this.btnSoma9.Name = "btnSoma9";
            this.btnSoma9.Size = new System.Drawing.Size(115, 71);
            this.btnSoma9.TabIndex = 8;
            this.btnSoma9.Text = "Função Void com parâmetro de saída e com parâmetro opcional";
            this.btnSoma9.UseVisualStyleBackColor = true;
            this.btnSoma9.Click += new System.EventHandler(this.BtnSoma9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSoma9);
            this.Controls.Add(this.btnSoma8);
            this.Controls.Add(this.btnSoma7);
            this.Controls.Add(this.btnSoma6);
            this.Controls.Add(this.btnSoma5);
            this.Controls.Add(this.btnSoma4);
            this.Controls.Add(this.btnSoma3);
            this.Controls.Add(this.btnSoma2);
            this.Controls.Add(this.btnSoma1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSoma1;
        private System.Windows.Forms.Button btnSoma2;
        private System.Windows.Forms.Button btnSoma3;
        private System.Windows.Forms.Button btnSoma4;
        private System.Windows.Forms.Button btnSoma5;
        private System.Windows.Forms.Button btnSoma6;
        private System.Windows.Forms.Button btnSoma7;
        private System.Windows.Forms.Button btnSoma8;
        private System.Windows.Forms.Button btnSoma9;
    }
}

