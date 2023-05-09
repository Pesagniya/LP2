namespace PLacos
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblProducao = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblGratif = new System.Windows.Forms.Label();
            this.mskbxNome = new System.Windows.Forms.MaskedTextBox();
            this.mskbxCargo = new System.Windows.Forms.MaskedTextBox();
            this.mskbxMatricula = new System.Windows.Forms.MaskedTextBox();
            this.mskbxProducao = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSal = new System.Windows.Forms.MaskedTextBox();
            this.mskbxGratif = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(313, 305);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 91);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular Salário Bruto";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(201, 72);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(201, 105);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(49, 18);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(201, 140);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(68, 18);
            this.lblMatricula.TabIndex = 4;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblProducao
            // 
            this.lblProducao.AutoSize = true;
            this.lblProducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducao.Location = new System.Drawing.Point(201, 173);
            this.lblProducao.Name = "lblProducao";
            this.lblProducao.Size = new System.Drawing.Size(73, 18);
            this.lblProducao.TabIndex = 5;
            this.lblProducao.Text = "Produção";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.Location = new System.Drawing.Point(201, 205);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(54, 18);
            this.lblSal.TabIndex = 6;
            this.lblSal.Text = "Salário";
            // 
            // lblGratif
            // 
            this.lblGratif.AutoSize = true;
            this.lblGratif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGratif.Location = new System.Drawing.Point(201, 237);
            this.lblGratif.Name = "lblGratif";
            this.lblGratif.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGratif.Size = new System.Drawing.Size(88, 18);
            this.lblGratif.TabIndex = 7;
            this.lblGratif.Text = "Gratificação";
            // 
            // mskbxNome
            // 
            this.mskbxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxNome.Location = new System.Drawing.Point(313, 72);
            this.mskbxNome.Mask = "??????????????????????????????????????????????????????";
            this.mskbxNome.Name = "mskbxNome";
            this.mskbxNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskbxNome.Size = new System.Drawing.Size(331, 24);
            this.mskbxNome.TabIndex = 8;
            this.mskbxNome.Validated += new System.EventHandler(this.mskbxNome_Validated);
            // 
            // mskbxCargo
            // 
            this.mskbxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxCargo.Location = new System.Drawing.Point(313, 105);
            this.mskbxCargo.Mask = "??????????????????????????????????????????????????????";
            this.mskbxCargo.Name = "mskbxCargo";
            this.mskbxCargo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskbxCargo.Size = new System.Drawing.Size(331, 24);
            this.mskbxCargo.TabIndex = 9;
            this.mskbxCargo.Validated += new System.EventHandler(this.mskbxCargo_Validated);
            // 
            // mskbxMatricula
            // 
            this.mskbxMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxMatricula.Location = new System.Drawing.Point(313, 140);
            this.mskbxMatricula.Mask = "0000000009";
            this.mskbxMatricula.Name = "mskbxMatricula";
            this.mskbxMatricula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskbxMatricula.Size = new System.Drawing.Size(91, 24);
            this.mskbxMatricula.TabIndex = 10;
            this.mskbxMatricula.ValidatingType = typeof(int);
            this.mskbxMatricula.Validated += new System.EventHandler(this.mskbxMatricula_Validated);
            // 
            // mskbxProducao
            // 
            this.mskbxProducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxProducao.Location = new System.Drawing.Point(313, 173);
            this.mskbxProducao.Mask = "0000000000";
            this.mskbxProducao.Name = "mskbxProducao";
            this.mskbxProducao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskbxProducao.Size = new System.Drawing.Size(91, 24);
            this.mskbxProducao.TabIndex = 11;
            this.mskbxProducao.Validated += new System.EventHandler(this.mskbxProducao_Validated);
            // 
            // mskbxSal
            // 
            this.mskbxSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSal.Location = new System.Drawing.Point(313, 205);
            this.mskbxSal.Mask = "00000000.00";
            this.mskbxSal.Name = "mskbxSal";
            this.mskbxSal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskbxSal.Size = new System.Drawing.Size(91, 24);
            this.mskbxSal.TabIndex = 12;
            this.mskbxSal.Validated += new System.EventHandler(this.mskbxSal_Validated);
            // 
            // mskbxGratif
            // 
            this.mskbxGratif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxGratif.Location = new System.Drawing.Point(313, 237);
            this.mskbxGratif.Mask = "00000000.00";
            this.mskbxGratif.Name = "mskbxGratif";
            this.mskbxGratif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskbxGratif.Size = new System.Drawing.Size(91, 24);
            this.mskbxGratif.TabIndex = 13;
            this.mskbxGratif.Text = "       000";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskbxGratif);
            this.Controls.Add(this.mskbxSal);
            this.Controls.Add(this.mskbxProducao);
            this.Controls.Add(this.mskbxMatricula);
            this.Controls.Add(this.mskbxCargo);
            this.Controls.Add(this.mskbxNome);
            this.Controls.Add(this.lblGratif);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblProducao);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCalcular);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblProducao;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblGratif;
        private System.Windows.Forms.MaskedTextBox mskbxNome;
        private System.Windows.Forms.MaskedTextBox mskbxCargo;
        private System.Windows.Forms.MaskedTextBox mskbxMatricula;
        private System.Windows.Forms.MaskedTextBox mskbxProducao;
        private System.Windows.Forms.MaskedTextBox mskbxSal;
        private System.Windows.Forms.MaskedTextBox mskbxGratif;
    }
}