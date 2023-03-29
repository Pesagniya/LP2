namespace PSalario
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblLiquido = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudFilhos = new System.Windows.Forms.NumericUpDown();
            this.mskbxBruto = new System.Windows.Forms.MaskedTextBox();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.mskbxINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskbxLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.gbxSex = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.pnlCasamento = new System.Windows.Forms.Panel();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilhos)).BeginInit();
            this.gbxSex.SuspendLayout();
            this.pnlCasamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(87, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome do funcionário";
            // 
            // lblBruto
            // 
            this.lblBruto.AutoSize = true;
            this.lblBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruto.Location = new System.Drawing.Point(134, 81);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(85, 16);
            this.lblBruto.TabIndex = 1;
            this.lblBruto.Text = "Salário Bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilhos.Location = new System.Drawing.Point(110, 120);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(109, 16);
            this.lblFilhos.TabIndex = 2;
            this.lblFilhos.Text = "Número de filhos";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.Location = new System.Drawing.Point(134, 243);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(43, 15);
            this.lblDados.TabIndex = 3;
            this.lblDados.Text = "Dados";
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSS.Location = new System.Drawing.Point(128, 279);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(91, 16);
            this.lblINSS.TabIndex = 4;
            this.lblINSS.Text = "Alíquota INSS";
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRPF.Location = new System.Drawing.Point(129, 318);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(90, 16);
            this.lblIRPF.TabIndex = 5;
            this.lblIRPF.Text = "Alíquota IRPF";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalFamilia.Location = new System.Drawing.Point(121, 358);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(98, 16);
            this.lblSalFamilia.TabIndex = 6;
            this.lblSalFamilia.Text = "Salário Família";
            // 
            // lblLiquido
            // 
            this.lblLiquido.AutoSize = true;
            this.lblLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquido.Location = new System.Drawing.Point(121, 398);
            this.lblLiquido.Name = "lblLiquido";
            this.lblLiquido.Size = new System.Drawing.Size(98, 16);
            this.lblLiquido.TabIndex = 7;
            this.lblLiquido.Text = "Salário Líquido";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescINSS.Location = new System.Drawing.Point(389, 279);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(100, 16);
            this.lblDescINSS.TabIndex = 8;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(225, 166);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(133, 70);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Verificar Desconto";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(225, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 1;
            // 
            // nudFilhos
            // 
            this.nudFilhos.Location = new System.Drawing.Point(225, 120);
            this.nudFilhos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFilhos.Name = "nudFilhos";
            this.nudFilhos.Size = new System.Drawing.Size(120, 20);
            this.nudFilhos.TabIndex = 3;
            // 
            // mskbxBruto
            // 
            this.mskbxBruto.Location = new System.Drawing.Point(225, 80);
            this.mskbxBruto.Mask = "99990.00";
            this.mskbxBruto.Name = "mskbxBruto";
            this.mskbxBruto.Size = new System.Drawing.Size(120, 20);
            this.mskbxBruto.TabIndex = 2;
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescIRPF.Location = new System.Drawing.Point(390, 316);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(99, 16);
            this.lblDescIRPF.TabIndex = 20;
            this.lblDescIRPF.Text = "Desconto IRPF";
            // 
            // mskbxINSS
            // 
            this.mskbxINSS.Enabled = false;
            this.mskbxINSS.Location = new System.Drawing.Point(225, 278);
            this.mskbxINSS.Name = "mskbxINSS";
            this.mskbxINSS.Size = new System.Drawing.Size(120, 20);
            this.mskbxINSS.TabIndex = 21;
            // 
            // mskbxIRPF
            // 
            this.mskbxIRPF.Enabled = false;
            this.mskbxIRPF.Location = new System.Drawing.Point(225, 317);
            this.mskbxIRPF.Name = "mskbxIRPF";
            this.mskbxIRPF.Size = new System.Drawing.Size(120, 20);
            this.mskbxIRPF.TabIndex = 22;
            // 
            // mskbxSalFamilia
            // 
            this.mskbxSalFamilia.Enabled = false;
            this.mskbxSalFamilia.Location = new System.Drawing.Point(225, 357);
            this.mskbxSalFamilia.Name = "mskbxSalFamilia";
            this.mskbxSalFamilia.Size = new System.Drawing.Size(120, 20);
            this.mskbxSalFamilia.TabIndex = 23;
            // 
            // mskbxLiquido
            // 
            this.mskbxLiquido.Enabled = false;
            this.mskbxLiquido.Location = new System.Drawing.Point(225, 398);
            this.mskbxLiquido.Name = "mskbxLiquido";
            this.mskbxLiquido.Size = new System.Drawing.Size(120, 20);
            this.mskbxLiquido.TabIndex = 24;
            // 
            // mskbxDescINSS
            // 
            this.mskbxDescINSS.Enabled = false;
            this.mskbxDescINSS.Location = new System.Drawing.Point(495, 278);
            this.mskbxDescINSS.Name = "mskbxDescINSS";
            this.mskbxDescINSS.Size = new System.Drawing.Size(120, 20);
            this.mskbxDescINSS.TabIndex = 25;
            // 
            // mskbxDescIRPF
            // 
            this.mskbxDescIRPF.Enabled = false;
            this.mskbxDescIRPF.Location = new System.Drawing.Point(495, 318);
            this.mskbxDescIRPF.Name = "mskbxDescIRPF";
            this.mskbxDescIRPF.Size = new System.Drawing.Size(120, 20);
            this.mskbxDescIRPF.TabIndex = 26;
            // 
            // gbxSex
            // 
            this.gbxSex.Controls.Add(this.rbtnFemale);
            this.gbxSex.Controls.Add(this.rbtnMale);
            this.gbxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSex.Location = new System.Drawing.Point(472, 36);
            this.gbxSex.Name = "gbxSex";
            this.gbxSex.Size = new System.Drawing.Size(200, 100);
            this.gbxSex.TabIndex = 27;
            this.gbxSex.TabStop = false;
            this.gbxSex.Text = "Sexo";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(23, 62);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(34, 20);
            this.rbtnFemale.TabIndex = 5;
            this.rbtnFemale.Text = "F";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Location = new System.Drawing.Point(23, 28);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(37, 20);
            this.rbtnMale.TabIndex = 4;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "M";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // pnlCasamento
            // 
            this.pnlCasamento.Controls.Add(this.ckbxCasado);
            this.pnlCasamento.Location = new System.Drawing.Point(472, 166);
            this.pnlCasamento.Name = "pnlCasamento";
            this.pnlCasamento.Size = new System.Drawing.Size(200, 60);
            this.pnlCasamento.TabIndex = 28;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxCasado.Location = new System.Drawing.Point(23, 26);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(75, 20);
            this.ckbxCasado.TabIndex = 6;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCasamento);
            this.Controls.Add(this.gbxSex);
            this.Controls.Add(this.mskbxDescIRPF);
            this.Controls.Add(this.mskbxDescINSS);
            this.Controls.Add(this.mskbxLiquido);
            this.Controls.Add(this.mskbxSalFamilia);
            this.Controls.Add(this.mskbxIRPF);
            this.Controls.Add(this.mskbxINSS);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.mskbxBruto);
            this.Controls.Add(this.nudFilhos);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblLiquido);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblBruto);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudFilhos)).EndInit();
            this.gbxSex.ResumeLayout(false);
            this.gbxSex.PerformLayout();
            this.pnlCasamento.ResumeLayout(false);
            this.pnlCasamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblLiquido;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxBruto;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxINSS;
        private System.Windows.Forms.MaskedTextBox mskbxIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxSalFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxLiquido;
        private System.Windows.Forms.MaskedTextBox mskbxDescINSS;
        private System.Windows.Forms.MaskedTextBox mskbxDescIRPF;
        private System.Windows.Forms.GroupBox gbxSex;
        private System.Windows.Forms.Panel pnlCasamento;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.CheckBox ckbxCasado;
    }
}

