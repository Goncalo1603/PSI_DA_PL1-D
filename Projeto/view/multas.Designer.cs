namespace Projeto.modelos
{
    partial class multas
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
            this.labelmultas = new System.Windows.Forms.Label();
            this.buttoncriarmulta = new System.Windows.Forms.Button();
            this.labelnomeCliente = new System.Windows.Forms.Label();
            this.buttonatualizarCliente = new System.Windows.Forms.Button();
            this.buttonapagarCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownmultaatraso = new System.Windows.Forms.NumericUpDown();
            this.numericUpDowntempoatraso = new System.Windows.Forms.NumericUpDown();
            this.labelnifCliente = new System.Windows.Forms.Label();
            this.listBoxmultas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmultaatraso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowntempoatraso)).BeginInit();
            this.SuspendLayout();
            // 
            // labelmultas
            // 
            this.labelmultas.AutoSize = true;
            this.labelmultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmultas.Location = new System.Drawing.Point(12, 37);
            this.labelmultas.Name = "labelmultas";
            this.labelmultas.Size = new System.Drawing.Size(83, 29);
            this.labelmultas.TabIndex = 10;
            this.labelmultas.Text = "Multas";
            // 
            // buttoncriarmulta
            // 
            this.buttoncriarmulta.BackColor = System.Drawing.Color.Blue;
            this.buttoncriarmulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncriarmulta.Location = new System.Drawing.Point(17, 482);
            this.buttoncriarmulta.Name = "buttoncriarmulta";
            this.buttoncriarmulta.Size = new System.Drawing.Size(150, 46);
            this.buttoncriarmulta.TabIndex = 12;
            this.buttoncriarmulta.Text = "Criar Multa";
            this.buttoncriarmulta.UseVisualStyleBackColor = false;
            // 
            // labelnomeCliente
            // 
            this.labelnomeCliente.AutoSize = true;
            this.labelnomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomeCliente.Location = new System.Drawing.Point(303, 80);
            this.labelnomeCliente.Name = "labelnomeCliente";
            this.labelnomeCliente.Size = new System.Drawing.Size(156, 24);
            this.labelnomeCliente.TabIndex = 2;
            this.labelnomeCliente.Text = "Tempo de Atraso";
            // 
            // buttonatualizarCliente
            // 
            this.buttonatualizarCliente.BackColor = System.Drawing.Color.Blue;
            this.buttonatualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonatualizarCliente.Location = new System.Drawing.Point(327, 445);
            this.buttonatualizarCliente.Name = "buttonatualizarCliente";
            this.buttonatualizarCliente.Size = new System.Drawing.Size(120, 35);
            this.buttonatualizarCliente.TabIndex = 1;
            this.buttonatualizarCliente.Text = "Salvar";
            this.buttonatualizarCliente.UseVisualStyleBackColor = false;
            // 
            // buttonapagarCliente
            // 
            this.buttonapagarCliente.BackColor = System.Drawing.Color.Blue;
            this.buttonapagarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonapagarCliente.Location = new System.Drawing.Point(327, 391);
            this.buttonapagarCliente.Name = "buttonapagarCliente";
            this.buttonapagarCliente.Size = new System.Drawing.Size(120, 35);
            this.buttonapagarCliente.TabIndex = 0;
            this.buttonapagarCliente.Text = "Apagar";
            this.buttonapagarCliente.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownmultaatraso);
            this.groupBox1.Controls.Add(this.numericUpDowntempoatraso);
            this.groupBox1.Controls.Add(this.labelnifCliente);
            this.groupBox1.Controls.Add(this.labelnomeCliente);
            this.groupBox1.Controls.Add(this.buttonatualizarCliente);
            this.groupBox1.Controls.Add(this.buttonapagarCliente);
            this.groupBox1.Location = new System.Drawing.Point(196, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 491);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar Multa";
            // 
            // numericUpDownmultaatraso
            // 
            this.numericUpDownmultaatraso.Location = new System.Drawing.Point(307, 210);
            this.numericUpDownmultaatraso.Name = "numericUpDownmultaatraso";
            this.numericUpDownmultaatraso.Size = new System.Drawing.Size(152, 20);
            this.numericUpDownmultaatraso.TabIndex = 5;
            // 
            // numericUpDowntempoatraso
            // 
            this.numericUpDowntempoatraso.Location = new System.Drawing.Point(307, 125);
            this.numericUpDowntempoatraso.Name = "numericUpDowntempoatraso";
            this.numericUpDowntempoatraso.Size = new System.Drawing.Size(152, 20);
            this.numericUpDowntempoatraso.TabIndex = 4;
            // 
            // labelnifCliente
            // 
            this.labelnifCliente.AutoSize = true;
            this.labelnifCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnifCliente.Location = new System.Drawing.Point(307, 168);
            this.labelnifCliente.Name = "labelnifCliente";
            this.labelnifCliente.Size = new System.Drawing.Size(152, 24);
            this.labelnifCliente.TabIndex = 3;
            this.labelnifCliente.Text = "Multa pelo atraso";
            // 
            // listBoxmultas
            // 
            this.listBoxmultas.FormattingEnabled = true;
            this.listBoxmultas.Location = new System.Drawing.Point(17, 69);
            this.listBoxmultas.Name = "listBoxmultas";
            this.listBoxmultas.Size = new System.Drawing.Size(150, 394);
            this.listBoxmultas.TabIndex = 11;
            // 
            // multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 565);
            this.Controls.Add(this.labelmultas);
            this.Controls.Add(this.buttoncriarmulta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxmultas);
            this.Name = "multas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "multas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmultaatraso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowntempoatraso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmultas;
        private System.Windows.Forms.Button buttoncriarmulta;
        private System.Windows.Forms.Label labelnomeCliente;
        private System.Windows.Forms.Button buttonatualizarCliente;
        private System.Windows.Forms.Button buttonapagarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelnifCliente;
        private System.Windows.Forms.ListBox listBoxmultas;
        private System.Windows.Forms.NumericUpDown numericUpDowntempoatraso;
        private System.Windows.Forms.NumericUpDown numericUpDownmultaatraso;
    }
}