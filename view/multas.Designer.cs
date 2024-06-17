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
            this.buttonapagarMulta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownmultaatraso = new System.Windows.Forms.NumericUpDown();
            this.numericUpDowntempoatraso = new System.Windows.Forms.NumericUpDown();
            this.labelnifCliente = new System.Windows.Forms.Label();
            this.listBoxmultas = new System.Windows.Forms.ListBox();
            this.buttonvoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmultaatraso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowntempoatraso)).BeginInit();
            this.SuspendLayout();
            // 
            // labelmultas
            // 
            this.labelmultas.AutoSize = true;
            this.labelmultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmultas.Location = new System.Drawing.Point(18, 57);
            this.labelmultas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmultas.Name = "labelmultas";
            this.labelmultas.Size = new System.Drawing.Size(123, 40);
            this.labelmultas.TabIndex = 10;
            this.labelmultas.Text = "Multas";
            // 
            // buttoncriarmulta
            // 
            this.buttoncriarmulta.BackColor = System.Drawing.Color.Blue;
            this.buttoncriarmulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncriarmulta.Location = new System.Drawing.Point(26, 742);
            this.buttoncriarmulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttoncriarmulta.Name = "buttoncriarmulta";
            this.buttoncriarmulta.Size = new System.Drawing.Size(225, 71);
            this.buttoncriarmulta.TabIndex = 12;
            this.buttoncriarmulta.Text = "Criar Multa";
            this.buttoncriarmulta.UseVisualStyleBackColor = false;
            this.buttoncriarmulta.Click += new System.EventHandler(this.buttoncriarmulta_Click);
            // 
            // labelnomeCliente
            // 
            this.labelnomeCliente.AutoSize = true;
            this.labelnomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomeCliente.Location = new System.Drawing.Point(454, 123);
            this.labelnomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnomeCliente.Name = "labelnomeCliente";
            this.labelnomeCliente.Size = new System.Drawing.Size(238, 33);
            this.labelnomeCliente.TabIndex = 2;
            this.labelnomeCliente.Text = "Tempo de Atraso";
            // 
            // buttonatualizarCliente
            // 
            this.buttonatualizarCliente.BackColor = System.Drawing.Color.Blue;
            this.buttonatualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonatualizarCliente.Location = new System.Drawing.Point(490, 685);
            this.buttonatualizarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonatualizarCliente.Name = "buttonatualizarCliente";
            this.buttonatualizarCliente.Size = new System.Drawing.Size(180, 54);
            this.buttonatualizarCliente.TabIndex = 1;
            this.buttonatualizarCliente.Text = "Salvar";
            this.buttonatualizarCliente.UseVisualStyleBackColor = false;
            this.buttonatualizarCliente.Click += new System.EventHandler(this.buttonatualizarCliente_Click);
            // 
            // buttonapagarMulta
            // 
            this.buttonapagarMulta.BackColor = System.Drawing.Color.Blue;
            this.buttonapagarMulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonapagarMulta.Location = new System.Drawing.Point(490, 602);
            this.buttonapagarMulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonapagarMulta.Name = "buttonapagarMulta";
            this.buttonapagarMulta.Size = new System.Drawing.Size(180, 54);
            this.buttonapagarMulta.TabIndex = 0;
            this.buttonapagarMulta.Text = "Apagar";
            this.buttonapagarMulta.UseVisualStyleBackColor = false;
            this.buttonapagarMulta.Click += new System.EventHandler(this.buttonapagarMulta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownmultaatraso);
            this.groupBox1.Controls.Add(this.numericUpDowntempoatraso);
            this.groupBox1.Controls.Add(this.labelnifCliente);
            this.groupBox1.Controls.Add(this.labelnomeCliente);
            this.groupBox1.Controls.Add(this.buttonatualizarCliente);
            this.groupBox1.Controls.Add(this.buttonapagarMulta);
            this.groupBox1.Location = new System.Drawing.Point(294, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1142, 755);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar Multa";
            // 
            // numericUpDownmultaatraso
            // 
            this.numericUpDownmultaatraso.Location = new System.Drawing.Point(460, 323);
            this.numericUpDownmultaatraso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownmultaatraso.Name = "numericUpDownmultaatraso";
            this.numericUpDownmultaatraso.Size = new System.Drawing.Size(228, 26);
            this.numericUpDownmultaatraso.TabIndex = 5;
            // 
            // numericUpDowntempoatraso
            // 
            this.numericUpDowntempoatraso.Location = new System.Drawing.Point(460, 192);
            this.numericUpDowntempoatraso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDowntempoatraso.Name = "numericUpDowntempoatraso";
            this.numericUpDowntempoatraso.Size = new System.Drawing.Size(228, 26);
            this.numericUpDowntempoatraso.TabIndex = 4;
            // 
            // labelnifCliente
            // 
            this.labelnifCliente.AutoSize = true;
            this.labelnifCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnifCliente.Location = new System.Drawing.Point(460, 258);
            this.labelnifCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnifCliente.Name = "labelnifCliente";
            this.labelnifCliente.Size = new System.Drawing.Size(238, 33);
            this.labelnifCliente.TabIndex = 3;
            this.labelnifCliente.Text = "Multa pelo atraso";
            // 
            // listBoxmultas
            // 
            this.listBoxmultas.FormattingEnabled = true;
            this.listBoxmultas.ItemHeight = 20;
            this.listBoxmultas.Location = new System.Drawing.Point(26, 106);
            this.listBoxmultas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxmultas.Name = "listBoxmultas";
            this.listBoxmultas.Size = new System.Drawing.Size(223, 604);
            this.listBoxmultas.TabIndex = 11;
            // 
            // buttonvoltar
            // 
            this.buttonvoltar.BackColor = System.Drawing.Color.Blue;
            this.buttonvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonvoltar.Location = new System.Drawing.Point(26, 14);
            this.buttonvoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonvoltar.Name = "buttonvoltar";
            this.buttonvoltar.Size = new System.Drawing.Size(225, 34);
            this.buttonvoltar.TabIndex = 14;
            this.buttonvoltar.Text = "Voltar";
            this.buttonvoltar.UseVisualStyleBackColor = false;
            this.buttonvoltar.Click += new System.EventHandler(this.buttonvoltar_Click);
            // 
            // multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 869);
            this.Controls.Add(this.buttonvoltar);
            this.Controls.Add(this.labelmultas);
            this.Controls.Add(this.buttoncriarmulta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxmultas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button buttonapagarMulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelnifCliente;
        private System.Windows.Forms.ListBox listBoxmultas;
        private System.Windows.Forms.NumericUpDown numericUpDowntempoatraso;
        private System.Windows.Forms.NumericUpDown numericUpDownmultaatraso;
        private System.Windows.Forms.Button buttonvoltar;
    }
}