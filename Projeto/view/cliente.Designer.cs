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
            this.labelnifCliente = new System.Windows.Forms.Label();
            this.labelnomeCliente = new System.Windows.Forms.Label();
            this.buttonatualizarCliente = new System.Windows.Forms.Button();
            this.buttonapagarCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.buttonok = new System.Windows.Forms.Button();
            this.textBoxinserirnumemail = new System.Windows.Forms.TextBox();
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
            this.labelclientes.Location = new System.Drawing.Point(12, 27);
            this.labelclientes.Name = "labelclientes";
            this.labelclientes.Size = new System.Drawing.Size(101, 29);
            this.labelclientes.TabIndex = 0;
            this.labelclientes.Text = "Clientes";
            // 
            // listBoxclientes
            // 
            this.listBoxclientes.FormattingEnabled = true;
            this.listBoxclientes.Location = new System.Drawing.Point(17, 59);
            this.listBoxclientes.Name = "listBoxclientes";
            this.listBoxclientes.Size = new System.Drawing.Size(150, 394);
            this.listBoxclientes.TabIndex = 1;
            // 
            // buttoncriarcliente
            // 
            this.buttoncriarcliente.BackColor = System.Drawing.Color.Blue;
            this.buttoncriarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncriarcliente.Location = new System.Drawing.Point(17, 472);
            this.buttoncriarcliente.Name = "buttoncriarcliente";
            this.buttoncriarcliente.Size = new System.Drawing.Size(150, 46);
            this.buttoncriarcliente.TabIndex = 2;
            this.buttoncriarcliente.Text = "Criar Cliente";
            this.buttoncriarcliente.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelnifCliente);
            this.groupBox1.Controls.Add(this.labelnomeCliente);
            this.groupBox1.Controls.Add(this.buttonatualizarCliente);
            this.groupBox1.Controls.Add(this.buttonapagarCliente);
            this.groupBox1.Location = new System.Drawing.Point(196, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente Selecionado";
            // 
            // labelnifCliente
            // 
            this.labelnifCliente.AutoSize = true;
            this.labelnifCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnifCliente.Location = new System.Drawing.Point(30, 97);
            this.labelnifCliente.Name = "labelnifCliente";
            this.labelnifCliente.Size = new System.Drawing.Size(32, 24);
            this.labelnifCliente.TabIndex = 3;
            this.labelnifCliente.Text = "Nif";
            // 
            // labelnomeCliente
            // 
            this.labelnomeCliente.AutoSize = true;
            this.labelnomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomeCliente.Location = new System.Drawing.Point(30, 32);
            this.labelnomeCliente.Name = "labelnomeCliente";
            this.labelnomeCliente.Size = new System.Drawing.Size(125, 24);
            this.labelnomeCliente.TabIndex = 2;
            this.labelnomeCliente.Text = "Nome Cliente";
            // 
            // buttonatualizarCliente
            // 
            this.buttonatualizarCliente.BackColor = System.Drawing.Color.Blue;
            this.buttonatualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonatualizarCliente.Location = new System.Drawing.Point(635, 111);
            this.buttonatualizarCliente.Name = "buttonatualizarCliente";
            this.buttonatualizarCliente.Size = new System.Drawing.Size(120, 35);
            this.buttonatualizarCliente.TabIndex = 1;
            this.buttonatualizarCliente.Text = "Atualizar Informações";
            this.buttonatualizarCliente.UseVisualStyleBackColor = false;
            // 
            // buttonapagarCliente
            // 
            this.buttonapagarCliente.BackColor = System.Drawing.Color.Blue;
            this.buttonapagarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonapagarCliente.Location = new System.Drawing.Point(635, 54);
            this.buttonapagarCliente.Name = "buttonapagarCliente";
            this.buttonapagarCliente.Size = new System.Drawing.Size(120, 35);
            this.buttonapagarCliente.TabIndex = 0;
            this.buttonapagarCliente.Text = "Apagar";
            this.buttonapagarCliente.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttoncancelar);
            this.groupBox2.Controls.Add(this.buttonok);
            this.groupBox2.Controls.Add(this.textBoxinserirnumemail);
            this.groupBox2.Controls.Add(this.labelinserirnumemail);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButtonaluno);
            this.groupBox2.Controls.Add(this.textBoxinserirNif);
            this.groupBox2.Controls.Add(this.labelinserirNif);
            this.groupBox2.Controls.Add(this.labelinserirnome);
            this.groupBox2.Controls.Add(this.textBoxinserirNome);
            this.groupBox2.Location = new System.Drawing.Point(196, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 283);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBoxCriarAlterarCliente";
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.BackColor = System.Drawing.Color.Blue;
            this.buttoncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncancelar.Location = new System.Drawing.Point(622, 141);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(120, 35);
            this.buttoncancelar.TabIndex = 9;
            this.buttoncancelar.Text = "Cancelar";
            this.buttoncancelar.UseVisualStyleBackColor = false;
            // 
            // buttonok
            // 
            this.buttonok.BackColor = System.Drawing.Color.Blue;
            this.buttonok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonok.Location = new System.Drawing.Point(622, 77);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(120, 35);
            this.buttonok.TabIndex = 8;
            this.buttonok.Text = "Ok";
            this.buttonok.UseVisualStyleBackColor = false;
            // 
            // textBoxinserirnumemail
            // 
            this.textBoxinserirnumemail.Location = new System.Drawing.Point(7, 221);
            this.textBoxinserirnumemail.Name = "textBoxinserirnumemail";
            this.textBoxinserirnumemail.Size = new System.Drawing.Size(489, 20);
            this.textBoxinserirnumemail.TabIndex = 7;
            // 
            // labelinserirnumemail
            // 
            this.labelinserirnumemail.AutoSize = true;
            this.labelinserirnumemail.Location = new System.Drawing.Point(7, 205);
            this.labelinserirnumemail.Name = "labelinserirnumemail";
            this.labelinserirnumemail.Size = new System.Drawing.Size(138, 13);
            this.labelinserirnumemail.TabIndex = 6;
            this.labelinserirnumemail.Text = "Numero de estudante/email";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 159);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Professor";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButtonaluno
            // 
            this.radioButtonaluno.AutoSize = true;
            this.radioButtonaluno.Location = new System.Drawing.Point(10, 136);
            this.radioButtonaluno.Name = "radioButtonaluno";
            this.radioButtonaluno.Size = new System.Drawing.Size(52, 17);
            this.radioButtonaluno.TabIndex = 4;
            this.radioButtonaluno.TabStop = true;
            this.radioButtonaluno.Text = "Aluno";
            this.radioButtonaluno.UseVisualStyleBackColor = true;
            // 
            // textBoxinserirNif
            // 
            this.textBoxinserirNif.Location = new System.Drawing.Point(7, 92);
            this.textBoxinserirNif.Name = "textBoxinserirNif";
            this.textBoxinserirNif.Size = new System.Drawing.Size(489, 20);
            this.textBoxinserirNif.TabIndex = 3;
            this.textBoxinserirNif.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelinserirNif
            // 
            this.labelinserirNif.AutoSize = true;
            this.labelinserirNif.Location = new System.Drawing.Point(7, 76);
            this.labelinserirNif.Name = "labelinserirNif";
            this.labelinserirNif.Size = new System.Drawing.Size(20, 13);
            this.labelinserirNif.TabIndex = 2;
            this.labelinserirNif.Text = "Nif";
            // 
            // labelinserirnome
            // 
            this.labelinserirnome.AutoSize = true;
            this.labelinserirnome.Location = new System.Drawing.Point(7, 20);
            this.labelinserirnome.Name = "labelinserirnome";
            this.labelinserirnome.Size = new System.Drawing.Size(35, 13);
            this.labelinserirnome.TabIndex = 1;
            this.labelinserirnome.Text = "Nome";
            // 
            // textBoxinserirNome
            // 
            this.textBoxinserirNome.Location = new System.Drawing.Point(7, 38);
            this.textBoxinserirNome.Name = "textBoxinserirNome";
            this.textBoxinserirNome.Size = new System.Drawing.Size(489, 20);
            this.textBoxinserirNome.TabIndex = 0;
            // 
            // buttonvoltar
            // 
            this.buttonvoltar.BackColor = System.Drawing.Color.Blue;
            this.buttonvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonvoltar.Location = new System.Drawing.Point(1, 2);
            this.buttonvoltar.Name = "buttonvoltar";
            this.buttonvoltar.Size = new System.Drawing.Size(150, 22);
            this.buttonvoltar.TabIndex = 5;
            this.buttonvoltar.Text = "Voltar";
            this.buttonvoltar.UseVisualStyleBackColor = false;
            this.buttonvoltar.Click += new System.EventHandler(this.buttonvoltar_Click);
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 565);
            this.Controls.Add(this.buttonvoltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttoncriarcliente);
            this.Controls.Add(this.listBoxclientes);
            this.Controls.Add(this.labelclientes);
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
        private System.Windows.Forms.Button buttonatualizarCliente;
        private System.Windows.Forms.Button buttonapagarCliente;
        private System.Windows.Forms.Label labelinserirnome;
        private System.Windows.Forms.TextBox textBoxinserirNome;
        private System.Windows.Forms.TextBox textBoxinserirNif;
        private System.Windows.Forms.Label labelinserirNif;
        private System.Windows.Forms.TextBox textBoxinserirnumemail;
        private System.Windows.Forms.Label labelinserirnumemail;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButtonaluno;
        private System.Windows.Forms.Button buttoncancelar;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.Button buttonvoltar;
    }
}