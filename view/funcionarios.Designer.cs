namespace Projeto
{
    partial class funcionarios
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.buttonok = new System.Windows.Forms.Button();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.labelinserirnumemail = new System.Windows.Forms.Label();
            this.textBoxinserirNif = new System.Windows.Forms.TextBox();
            this.labelinserirNif = new System.Windows.Forms.Label();
            this.labelinserirnome = new System.Windows.Forms.Label();
            this.textBoxinserirNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelnifCliente = new System.Windows.Forms.Label();
            this.labelnomeCliente = new System.Windows.Forms.Label();
<<<<<<< Updated upstream
            this.buttonatualizarCliente = new System.Windows.Forms.Button();
=======
>>>>>>> Stashed changes
            this.buttonapagarCliente = new System.Windows.Forms.Button();
            this.buttoncriarfuncionario = new System.Windows.Forms.Button();
            this.listBoxfuncionarios = new System.Windows.Forms.ListBox();
            this.labelfuncionarios = new System.Windows.Forms.Label();
            this.buttonvoltar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttoncancelar);
            this.groupBox2.Controls.Add(this.buttonok);
            this.groupBox2.Controls.Add(this.textBoxusername);
            this.groupBox2.Controls.Add(this.labelinserirnumemail);
            this.groupBox2.Controls.Add(this.textBoxinserirNif);
            this.groupBox2.Controls.Add(this.labelinserirNif);
            this.groupBox2.Controls.Add(this.labelinserirnome);
            this.groupBox2.Controls.Add(this.textBoxinserirNome);
            this.groupBox2.Location = new System.Drawing.Point(196, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 283);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CriarAlterarFuncionario";
            this.groupBox2.Visible = false;
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
            this.buttoncancelar.Click += new System.EventHandler(this.buttoncancelar_Click);
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
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(7, 157);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(489, 20);
            this.textBoxusername.TabIndex = 7;
            // 
            // labelinserirnumemail
            // 
            this.labelinserirnumemail.AutoSize = true;
            this.labelinserirnumemail.Location = new System.Drawing.Point(7, 141);
            this.labelinserirnumemail.Name = "labelinserirnumemail";
            this.labelinserirnumemail.Size = new System.Drawing.Size(55, 13);
            this.labelinserirnumemail.TabIndex = 6;
            this.labelinserirnumemail.Text = "Username";
            // 
            // textBoxinserirNif
            // 
            this.textBoxinserirNif.Location = new System.Drawing.Point(7, 92);
            this.textBoxinserirNif.Name = "textBoxinserirNif";
            this.textBoxinserirNif.Size = new System.Drawing.Size(489, 20);
            this.textBoxinserirNif.TabIndex = 3;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelusername);
            this.groupBox1.Controls.Add(this.labelnifCliente);
            this.groupBox1.Controls.Add(this.labelnomeCliente);
<<<<<<< Updated upstream
            this.groupBox1.Controls.Add(this.buttonatualizarCliente);
=======
>>>>>>> Stashed changes
            this.groupBox1.Controls.Add(this.buttonapagarCliente);
            this.groupBox1.Location = new System.Drawing.Point(196, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 181);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionario Selecionado";
            this.groupBox1.Visible = false;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(30, 122);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(97, 24);
            this.labelusername.TabIndex = 4;
            this.labelusername.Text = "Username";
            // 
            // labelnifCliente
            // 
            this.labelnifCliente.AutoSize = true;
            this.labelnifCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnifCliente.Location = new System.Drawing.Point(30, 80);
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
            this.labelnomeCliente.Size = new System.Drawing.Size(168, 24);
            this.labelnomeCliente.TabIndex = 2;
            this.labelnomeCliente.Text = "Nome Funcionario";
            // 
<<<<<<< Updated upstream
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
=======
>>>>>>> Stashed changes
            // buttonapagarCliente
            // 
            this.buttonapagarCliente.BackColor = System.Drawing.Color.Blue;
            this.buttonapagarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
<<<<<<< Updated upstream
            this.buttonapagarCliente.Location = new System.Drawing.Point(635, 54);
=======
            this.buttonapagarCliente.Location = new System.Drawing.Point(635, 89);
>>>>>>> Stashed changes
            this.buttonapagarCliente.Name = "buttonapagarCliente";
            this.buttonapagarCliente.Size = new System.Drawing.Size(120, 35);
            this.buttonapagarCliente.TabIndex = 0;
            this.buttonapagarCliente.Text = "Apagar";
            this.buttonapagarCliente.UseVisualStyleBackColor = false;
<<<<<<< Updated upstream
=======
            this.buttonapagarCliente.Click += new System.EventHandler(this.buttonapagarCliente_Click);
>>>>>>> Stashed changes
            // 
            // buttoncriarfuncionario
            // 
            this.buttoncriarfuncionario.BackColor = System.Drawing.Color.Blue;
            this.buttoncriarfuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncriarfuncionario.Location = new System.Drawing.Point(17, 482);
            this.buttoncriarfuncionario.Name = "buttoncriarfuncionario";
            this.buttoncriarfuncionario.Size = new System.Drawing.Size(150, 46);
            this.buttoncriarfuncionario.TabIndex = 7;
            this.buttoncriarfuncionario.Text = "Criar Funcionario";
            this.buttoncriarfuncionario.UseVisualStyleBackColor = false;
            this.buttoncriarfuncionario.Click += new System.EventHandler(this.buttoncriarfuncionario_Click);
            // 
            // listBoxfuncionarios
            // 
            this.listBoxfuncionarios.FormattingEnabled = true;
            this.listBoxfuncionarios.Location = new System.Drawing.Point(17, 69);
            this.listBoxfuncionarios.Name = "listBoxfuncionarios";
            this.listBoxfuncionarios.Size = new System.Drawing.Size(150, 394);
            this.listBoxfuncionarios.TabIndex = 6;
<<<<<<< Updated upstream
=======
            this.listBoxfuncionarios.SelectedIndexChanged += new System.EventHandler(this.listBoxfuncionarios_SelectedIndexChanged);
>>>>>>> Stashed changes
            // 
            // labelfuncionarios
            // 
            this.labelfuncionarios.AutoSize = true;
            this.labelfuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfuncionarios.Location = new System.Drawing.Point(12, 37);
            this.labelfuncionarios.Name = "labelfuncionarios";
            this.labelfuncionarios.Size = new System.Drawing.Size(140, 29);
            this.labelfuncionarios.TabIndex = 5;
            this.labelfuncionarios.Text = "Funcionario";
            // 
            // buttonvoltar
            // 
            this.buttonvoltar.BackColor = System.Drawing.Color.Blue;
            this.buttonvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonvoltar.Location = new System.Drawing.Point(17, 9);
            this.buttonvoltar.Name = "buttonvoltar";
            this.buttonvoltar.Size = new System.Drawing.Size(74, 25);
            this.buttonvoltar.TabIndex = 5;
            this.buttonvoltar.Text = "Voltar";
            this.buttonvoltar.UseVisualStyleBackColor = false;
            this.buttonvoltar.Click += new System.EventHandler(this.buttonvoltar_Click);
            // 
            // funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 565);
            this.Controls.Add(this.buttonvoltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttoncriarfuncionario);
            this.Controls.Add(this.listBoxfuncionarios);
            this.Controls.Add(this.labelfuncionarios);
            this.Name = "funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "funcinarios";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttoncancelar;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label labelinserirnumemail;
        private System.Windows.Forms.TextBox textBoxinserirNif;
        private System.Windows.Forms.Label labelinserirNif;
        private System.Windows.Forms.Label labelinserirnome;
        private System.Windows.Forms.TextBox textBoxinserirNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelnifCliente;
        private System.Windows.Forms.Label labelnomeCliente;
<<<<<<< Updated upstream
        private System.Windows.Forms.Button buttonatualizarCliente;
=======
>>>>>>> Stashed changes
        private System.Windows.Forms.Button buttonapagarCliente;
        private System.Windows.Forms.Button buttoncriarfuncionario;
        private System.Windows.Forms.ListBox listBoxfuncionarios;
        private System.Windows.Forms.Label labelfuncionarios;
        private System.Windows.Forms.Button buttonvoltar;
    }
}