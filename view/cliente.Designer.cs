namespace Projeto
{
    partial class cliente
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
            this.labelclientes = new System.Windows.Forms.Label();
            this.listBoxclientes = new System.Windows.Forms.ListBox();
            this.buttoncriarcliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelnumestudante = new System.Windows.Forms.Label();
            this.labelsaldo = new System.Windows.Forms.Label();
            this.labeltipocliente = new System.Windows.Forms.Label();
            this.labelnifCliente = new System.Windows.Forms.Label();
            this.labelnomeCliente = new System.Windows.Forms.Label();
            this.buttonapagarCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelinserirsaldo = new System.Windows.Forms.Label();
            this.textBoxinseriremail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.buttonok = new System.Windows.Forms.Button();
            this.texboxinserirnumestudante = new System.Windows.Forms.TextBox();
            this.labelinserirnumemail = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButtonaluno = new System.Windows.Forms.RadioButton();
            this.textBoxinserirNif = new System.Windows.Forms.TextBox();
            this.labelinserirNif = new System.Windows.Forms.Label();
            this.labelinserirnome = new System.Windows.Forms.Label();
            this.textBoxinserirNome = new System.Windows.Forms.TextBox();
            this.buttonvoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelclientes
            // 
            this.labelclientes.AutoSize = true;
            this.labelclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclientes.Location = new System.Drawing.Point(18, 42);
            this.labelclientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelclientes.Name = "labelclientes";
            this.labelclientes.Size = new System.Drawing.Size(147, 40);
            this.labelclientes.TabIndex = 0;
            this.labelclientes.Text = "Clientes";
            // 
            // listBoxclientes
            // 
            this.listBoxclientes.FormattingEnabled = true;
            this.listBoxclientes.ItemHeight = 20;
            this.listBoxclientes.Location = new System.Drawing.Point(26, 91);
            this.listBoxclientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxclientes.Name = "listBoxclientes";
            this.listBoxclientes.Size = new System.Drawing.Size(223, 604);
            this.listBoxclientes.TabIndex = 1;
            this.listBoxclientes.SelectedIndexChanged += new System.EventHandler(this.listBoxclientes_SelectedIndexChanged);
            // 
            // buttoncriarcliente
            // 
            this.buttoncriarcliente.BackColor = System.Drawing.Color.Blue;
            this.buttoncriarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncriarcliente.Location = new System.Drawing.Point(26, 726);
            this.buttoncriarcliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttoncriarcliente.Name = "buttoncriarcliente";
            this.buttoncriarcliente.Size = new System.Drawing.Size(225, 71);
            this.buttoncriarcliente.TabIndex = 2;
            this.buttoncriarcliente.Text = "Criar Cliente";
            this.buttoncriarcliente.UseVisualStyleBackColor = false;
            this.buttoncriarcliente.Click += new System.EventHandler(this.buttoncriarcliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelemail);
            this.groupBox1.Controls.Add(this.labelnumestudante);
            this.groupBox1.Controls.Add(this.labelsaldo);
            this.groupBox1.Controls.Add(this.labeltipocliente);
            this.groupBox1.Controls.Add(this.labelnifCliente);
            this.groupBox1.Controls.Add(this.labelnomeCliente);
            this.groupBox1.Controls.Add(this.buttonapagarCliente);
            this.groupBox1.Location = new System.Drawing.Point(294, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1142, 278);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente Selecionado";
            this.groupBox1.Visible = false;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(45, 212);
            this.labelemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(89, 33);
            this.labelemail.TabIndex = 7;
            this.labelemail.Text = "Email";
            // 
            // labelnumestudante
            // 
            this.labelnumestudante.AutoSize = true;
            this.labelnumestudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumestudante.Location = new System.Drawing.Point(45, 175);
            this.labelnumestudante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnumestudante.Name = "labelnumestudante";
            this.labelnumestudante.Size = new System.Drawing.Size(177, 33);
            this.labelnumestudante.TabIndex = 6;
            this.labelnumestudante.Text = "NºEstudante";
            // 
            // labelsaldo
            // 
            this.labelsaldo.AutoSize = true;
            this.labelsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsaldo.Location = new System.Drawing.Point(45, 138);
            this.labelsaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelsaldo.Name = "labelsaldo";
            this.labelsaldo.Size = new System.Drawing.Size(89, 33);
            this.labelsaldo.TabIndex = 5;
            this.labelsaldo.Text = "Saldo";
            // 
            // labeltipocliente
            // 
            this.labeltipocliente.AutoSize = true;
            this.labeltipocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltipocliente.Location = new System.Drawing.Point(45, 98);
            this.labeltipocliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltipocliente.Name = "labeltipocliente";
            this.labeltipocliente.Size = new System.Drawing.Size(205, 33);
            this.labeltipocliente.TabIndex = 4;
            this.labeltipocliente.Text = "Tipo de cliente";
            this.labeltipocliente.Click += new System.EventHandler(this.labeltipocliente_Click);
            // 
            // labelnifCliente
            // 
            this.labelnifCliente.AutoSize = true;
            this.labelnifCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnifCliente.Location = new System.Drawing.Point(45, 62);
            this.labelnifCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnifCliente.Name = "labelnifCliente";
            this.labelnifCliente.Size = new System.Drawing.Size(51, 33);
            this.labelnifCliente.TabIndex = 3;
            this.labelnifCliente.Text = "Nif";
            // 
            // labelnomeCliente
            // 
            this.labelnomeCliente.AutoSize = true;
            this.labelnomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomeCliente.Location = new System.Drawing.Point(45, 25);
            this.labelnomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnomeCliente.Name = "labelnomeCliente";
            this.labelnomeCliente.Size = new System.Drawing.Size(192, 33);
            this.labelnomeCliente.TabIndex = 2;
            this.labelnomeCliente.Text = "Nome Cliente";
            // 
            // buttonapagarCliente
            // 
            this.buttonapagarCliente.BackColor = System.Drawing.Color.Blue;
            this.buttonapagarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonapagarCliente.Location = new System.Drawing.Point(952, 122);
            this.buttonapagarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonapagarCliente.Name = "buttonapagarCliente";
            this.buttonapagarCliente.Size = new System.Drawing.Size(180, 54);
            this.buttonapagarCliente.TabIndex = 0;
            this.buttonapagarCliente.Text = "Apagar";
            this.buttonapagarCliente.UseVisualStyleBackColor = false;
            this.buttonapagarCliente.Click += new System.EventHandler(this.buttonapagarCliente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.labelinserirsaldo);
            this.groupBox2.Controls.Add(this.textBoxinseriremail);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttoncancelar);
            this.groupBox2.Controls.Add(this.buttonok);
            this.groupBox2.Controls.Add(this.texboxinserirnumestudante);
            this.groupBox2.Controls.Add(this.labelinserirnumemail);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButtonaluno);
            this.groupBox2.Controls.Add(this.textBoxinserirNif);
            this.groupBox2.Controls.Add(this.labelinserirNif);
            this.groupBox2.Controls.Add(this.labelinserirnome);
            this.groupBox2.Controls.Add(this.textBoxinserirNome);
            this.groupBox2.Location = new System.Drawing.Point(294, 362);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1142, 435);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBoxCriarAlterarCliente";
            this.groupBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 249);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(732, 26);
            this.textBox1.TabIndex = 13;
            // 
            // labelinserirsaldo
            // 
            this.labelinserirsaldo.AutoSize = true;
            this.labelinserirsaldo.Location = new System.Drawing.Point(10, 225);
            this.labelinserirsaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelinserirsaldo.Name = "labelinserirsaldo";
            this.labelinserirsaldo.Size = new System.Drawing.Size(50, 20);
            this.labelinserirsaldo.TabIndex = 12;
            this.labelinserirsaldo.Text = "Saldo";
            // 
            // textBoxinseriremail
            // 
            this.textBoxinseriremail.Location = new System.Drawing.Point(9, 395);
            this.textBoxinseriremail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxinseriremail.Name = "textBoxinseriremail";
            this.textBoxinseriremail.Size = new System.Drawing.Size(732, 26);
            this.textBoxinseriremail.TabIndex = 11;
            this.textBoxinseriremail.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 365);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            this.label1.Visible = false;
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.BackColor = System.Drawing.Color.Blue;
            this.buttoncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncancelar.Location = new System.Drawing.Point(933, 217);
            this.buttoncancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(180, 54);
            this.buttoncancelar.TabIndex = 9;
            this.buttoncancelar.Text = "Cancelar";
            this.buttoncancelar.UseVisualStyleBackColor = false;
            this.buttoncancelar.Click += new System.EventHandler(this.buttoncancelar_Click);
            // 
            // buttonok
            // 
            this.buttonok.BackColor = System.Drawing.Color.Blue;
            this.buttonok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonok.Location = new System.Drawing.Point(933, 118);
            this.buttonok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(180, 54);
            this.buttonok.TabIndex = 8;
            this.buttonok.Text = "Ok";
            this.buttonok.UseVisualStyleBackColor = false;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // texboxinserirnumestudante
            // 
            this.texboxinserirnumestudante.Location = new System.Drawing.Point(10, 309);
            this.texboxinserirnumestudante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.texboxinserirnumestudante.Name = "texboxinserirnumestudante";
            this.texboxinserirnumestudante.Size = new System.Drawing.Size(732, 26);
            this.texboxinserirnumestudante.TabIndex = 7;
            this.texboxinserirnumestudante.Visible = false;
            // 
            // labelinserirnumemail
            // 
            this.labelinserirnumemail.AutoSize = true;
            this.labelinserirnumemail.Location = new System.Drawing.Point(6, 285);
            this.labelinserirnumemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelinserirnumemail.Name = "labelinserirnumemail";
            this.labelinserirnumemail.Size = new System.Drawing.Size(163, 20);
            this.labelinserirnumemail.TabIndex = 6;
            this.labelinserirnumemail.Text = "Numero de estudante\r\n";
            this.labelinserirnumemail.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 194);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(102, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Professor";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonaluno
            // 
            this.radioButtonaluno.AutoSize = true;
            this.radioButtonaluno.Location = new System.Drawing.Point(9, 158);
            this.radioButtonaluno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonaluno.Name = "radioButtonaluno";
            this.radioButtonaluno.Size = new System.Drawing.Size(75, 24);
            this.radioButtonaluno.TabIndex = 4;
            this.radioButtonaluno.TabStop = true;
            this.radioButtonaluno.Text = "Aluno";
            this.radioButtonaluno.UseVisualStyleBackColor = true;
            this.radioButtonaluno.CheckedChanged += new System.EventHandler(this.radioButtonaluno_CheckedChanged);
            // 
            // textBoxinserirNif
            // 
            this.textBoxinserirNif.Location = new System.Drawing.Point(9, 118);
            this.textBoxinserirNif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxinserirNif.Name = "textBoxinserirNif";
            this.textBoxinserirNif.Size = new System.Drawing.Size(732, 26);
            this.textBoxinserirNif.TabIndex = 3;
            this.textBoxinserirNif.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelinserirNif
            // 
            this.labelinserirNif.AutoSize = true;
            this.labelinserirNif.Location = new System.Drawing.Point(10, 94);
            this.labelinserirNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelinserirNif.Name = "labelinserirNif";
            this.labelinserirNif.Size = new System.Drawing.Size(28, 20);
            this.labelinserirNif.TabIndex = 2;
            this.labelinserirNif.Text = "Nif";
            // 
            // labelinserirnome
            // 
            this.labelinserirnome.AutoSize = true;
            this.labelinserirnome.Location = new System.Drawing.Point(10, 31);
            this.labelinserirnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelinserirnome.Name = "labelinserirnome";
            this.labelinserirnome.Size = new System.Drawing.Size(51, 20);
            this.labelinserirnome.TabIndex = 1;
            this.labelinserirnome.Text = "Nome";
            // 
            // textBoxinserirNome
            // 
            this.textBoxinserirNome.Location = new System.Drawing.Point(10, 58);
            this.textBoxinserirNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxinserirNome.Name = "textBoxinserirNome";
            this.textBoxinserirNome.Size = new System.Drawing.Size(732, 26);
            this.textBoxinserirNome.TabIndex = 0;
            // 
            // buttonvoltar
            // 
            this.buttonvoltar.BackColor = System.Drawing.Color.Blue;
            this.buttonvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonvoltar.Location = new System.Drawing.Point(24, 3);
            this.buttonvoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonvoltar.Name = "buttonvoltar";
            this.buttonvoltar.Size = new System.Drawing.Size(225, 34);
            this.buttonvoltar.TabIndex = 5;
            this.buttonvoltar.Text = "Voltar";
            this.buttonvoltar.UseVisualStyleBackColor = false;
            this.buttonvoltar.Click += new System.EventHandler(this.buttonvoltar_Click);
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 869);
            this.Controls.Add(this.buttonvoltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttoncriarcliente);
            this.Controls.Add(this.listBoxclientes);
            this.Controls.Add(this.labelclientes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelclientes;
        private System.Windows.Forms.ListBox listBoxclientes;
        private System.Windows.Forms.Button buttoncriarcliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelnifCliente;
        private System.Windows.Forms.Label labelnomeCliente;
        private System.Windows.Forms.Button buttonapagarCliente;
        private System.Windows.Forms.Label labelinserirnome;
        private System.Windows.Forms.TextBox textBoxinserirNome;
        private System.Windows.Forms.TextBox textBoxinserirNif;
        private System.Windows.Forms.Label labelinserirNif;
        private System.Windows.Forms.TextBox texboxinserirnumestudante;
        private System.Windows.Forms.Label labelinserirnumemail;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButtonaluno;
        private System.Windows.Forms.Button buttoncancelar;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.Button buttonvoltar;
        private System.Windows.Forms.Label labeltipocliente;
        private System.Windows.Forms.TextBox textBoxinseriremail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelsaldo;
        private System.Windows.Forms.Label labelinserirsaldo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelnumestudante;
    }
}