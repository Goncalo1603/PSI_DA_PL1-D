namespace Projeto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonfuncionarios = new System.Windows.Forms.Button();
            this.buttonclientes = new System.Windows.Forms.Button();
            this.buttonreservas = new System.Windows.Forms.Button();
            this.buttonmultas = new System.Windows.Forms.Button();
            this.buttonmenu = new System.Windows.Forms.Button();
            this.buttonextras = new System.Windows.Forms.Button();
            this.buttonpratos = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Blue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 95);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(972, 45);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(429, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu Principal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonfuncionarios);
            this.groupBox1.Controls.Add(this.buttonclientes);
            this.groupBox1.Controls.Add(this.buttonreservas);
            this.groupBox1.Controls.Add(this.buttonmultas);
            this.groupBox1.Controls.Add(this.buttonmenu);
            this.groupBox1.Controls.Add(this.buttonextras);
            this.groupBox1.Controls.Add(this.buttonpratos);
            this.groupBox1.Location = new System.Drawing.Point(12, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 357);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu de Gestão";
            // 
            // buttonfuncionarios
            // 
            this.buttonfuncionarios.Location = new System.Drawing.Point(7, 288);
            this.buttonfuncionarios.Name = "buttonfuncionarios";
            this.buttonfuncionarios.Size = new System.Drawing.Size(127, 23);
            this.buttonfuncionarios.TabIndex = 4;
            this.buttonfuncionarios.Text = "Funcionarios";
            this.buttonfuncionarios.UseVisualStyleBackColor = true;
            this.buttonfuncionarios.Click += new System.EventHandler(this.buttonfuncionarios_Click);
            // 
            // buttonclientes
            // 
            this.buttonclientes.Location = new System.Drawing.Point(7, 247);
            this.buttonclientes.Name = "buttonclientes";
            this.buttonclientes.Size = new System.Drawing.Size(127, 23);
            this.buttonclientes.TabIndex = 4;
            this.buttonclientes.Text = "Clientes";
            this.buttonclientes.UseVisualStyleBackColor = true;
            // 
            // buttonreservas
            // 
            this.buttonreservas.Location = new System.Drawing.Point(7, 202);
            this.buttonreservas.Name = "buttonreservas";
            this.buttonreservas.Size = new System.Drawing.Size(127, 23);
            this.buttonreservas.TabIndex = 4;
            this.buttonreservas.Text = "Reservas";
            this.buttonreservas.UseVisualStyleBackColor = true;
            // 
            // buttonmultas
            // 
            this.buttonmultas.Location = new System.Drawing.Point(7, 158);
            this.buttonmultas.Name = "buttonmultas";
            this.buttonmultas.Size = new System.Drawing.Size(127, 23);
            this.buttonmultas.TabIndex = 3;
            this.buttonmultas.Text = "Multas";
            this.buttonmultas.UseVisualStyleBackColor = true;
            // 
            // buttonmenu
            // 
            this.buttonmenu.Location = new System.Drawing.Point(7, 116);
            this.buttonmenu.Name = "buttonmenu";
            this.buttonmenu.Size = new System.Drawing.Size(127, 23);
            this.buttonmenu.TabIndex = 2;
            this.buttonmenu.Text = "Menu";
            this.buttonmenu.UseVisualStyleBackColor = true;
            // 
            // buttonextras
            // 
            this.buttonextras.Location = new System.Drawing.Point(7, 75);
            this.buttonextras.Name = "buttonextras";
            this.buttonextras.Size = new System.Drawing.Size(127, 23);
            this.buttonextras.TabIndex = 1;
            this.buttonextras.Text = "Extras";
            this.buttonextras.UseVisualStyleBackColor = true;
            // 
            // buttonpratos
            // 
            this.buttonpratos.Location = new System.Drawing.Point(7, 33);
            this.buttonpratos.Name = "buttonpratos";
            this.buttonpratos.Size = new System.Drawing.Size(127, 23);
            this.buttonpratos.TabIndex = 0;
            this.buttonpratos.Text = "Pratos";
            this.buttonpratos.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 310);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(693, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 328);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu do Dia";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 20);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(251, 291);
            this.textBox2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecione o dia:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 565);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonfuncionarios;
        private System.Windows.Forms.Button buttonclientes;
        private System.Windows.Forms.Button buttonreservas;
        private System.Windows.Forms.Button buttonmultas;
        private System.Windows.Forms.Button buttonmenu;
        private System.Windows.Forms.Button buttonextras;
        private System.Windows.Forms.Button buttonpratos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

