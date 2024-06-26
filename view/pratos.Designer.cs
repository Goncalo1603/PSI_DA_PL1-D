namespace Projeto.view
{
    partial class pratos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pratos));
            this.pictureBoxICantina = new System.Windows.Forms.PictureBox();
            this.textBoxpratos = new System.Windows.Forms.TextBox();
            this.labelMenuDePratos = new System.Windows.Forms.Label();
            this.listBoxPratos = new System.Windows.Forms.ListBox();
            this.labelListaDePratos = new System.Windows.Forms.Label();
            this.buttonAtualizarPratos = new System.Windows.Forms.Button();
            this.buttonAdicionarNovoPrato = new System.Windows.Forms.Button();
            this.buttonEliminarPratos = new System.Windows.Forms.Button();
            this.labelAdicionarNovoPrato = new System.Windows.Forms.Label();
            this.labelDescricaoNovoPrato = new System.Windows.Forms.Label();
            this.labelTipoNovoPrato = new System.Windows.Forms.Label();
            this.textBoxDescricaoNovoPrato = new System.Windows.Forms.TextBox();
            this.textBoxTipoNovoPrato = new System.Windows.Forms.TextBox();
            this.buttonCarregarPratos = new System.Windows.Forms.Button();
            this.textBoxTipoAtualizarPrato = new System.Windows.Forms.TextBox();
            this.textBoxDescricaoAtualizarPrato = new System.Windows.Forms.TextBox();
            this.labelTipoAtualizarPrato = new System.Windows.Forms.Label();
            this.labelDescricaoAtualizarPrato = new System.Windows.Forms.Label();
            this.labelAtualizarPrato = new System.Windows.Forms.Label();
            this.textBoxAtivoNovoPrato = new System.Windows.Forms.TextBox();
            this.labelAtivoNovoPrato = new System.Windows.Forms.Label();
            this.textBoxAtivoAtualizarPrato = new System.Windows.Forms.TextBox();
            this.labelAtivoAtualizarPrato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxICantina)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxICantina
            // 
            this.pictureBoxICantina.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxICantina.Image")));
            this.pictureBoxICantina.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxICantina.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxICantina.Name = "pictureBoxICantina";
            this.pictureBoxICantina.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxICantina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxICantina.TabIndex = 1;
            this.pictureBoxICantina.TabStop = false;
            // 
            // textBoxpratos
            // 
            this.textBoxpratos.BackColor = System.Drawing.Color.Blue;
            this.textBoxpratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpratos.Location = new System.Drawing.Point(20, 208);
            this.textBoxpratos.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxpratos.Multiline = true;
            this.textBoxpratos.Name = "textBoxpratos";
            this.textBoxpratos.ReadOnly = true;
            this.textBoxpratos.Size = new System.Drawing.Size(1885, 82);
            this.textBoxpratos.TabIndex = 2;
            // 
            // labelMenuDePratos
            // 
            this.labelMenuDePratos.AutoSize = true;
            this.labelMenuDePratos.BackColor = System.Drawing.Color.Blue;
            this.labelMenuDePratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuDePratos.ForeColor = System.Drawing.Color.White;
            this.labelMenuDePratos.Location = new System.Drawing.Point(796, 212);
            this.labelMenuDePratos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMenuDePratos.Name = "labelMenuDePratos";
            this.labelMenuDePratos.Size = new System.Drawing.Size(377, 55);
            this.labelMenuDePratos.TabIndex = 3;
            this.labelMenuDePratos.Text = " Menu de Pratos";
            this.labelMenuDePratos.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxPratos
            // 
            this.listBoxPratos.FormattingEnabled = true;
            this.listBoxPratos.ItemHeight = 25;
            this.listBoxPratos.Location = new System.Drawing.Point(20, 389);
            this.listBoxPratos.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxPratos.Name = "listBoxPratos";
            this.listBoxPratos.Size = new System.Drawing.Size(664, 554);
            this.listBoxPratos.TabIndex = 4;
            this.listBoxPratos.SelectedIndexChanged += new System.EventHandler(this.listBoxclientes_SelectedIndexChanged);
            // 
            // labelListaDePratos
            // 
            this.labelListaDePratos.AutoSize = true;
            this.labelListaDePratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaDePratos.Location = new System.Drawing.Point(20, 327);
            this.labelListaDePratos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelListaDePratos.Name = "labelListaDePratos";
            this.labelListaDePratos.Size = new System.Drawing.Size(344, 55);
            this.labelListaDePratos.TabIndex = 5;
            this.labelListaDePratos.Text = "Lista de Pratos";
            // 
            // buttonAtualizarPratos
            // 
            this.buttonAtualizarPratos.BackColor = System.Drawing.Color.Blue;
            this.buttonAtualizarPratos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAtualizarPratos.Location = new System.Drawing.Point(1530, 948);
            this.buttonAtualizarPratos.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAtualizarPratos.Name = "buttonAtualizarPratos";
            this.buttonAtualizarPratos.Size = new System.Drawing.Size(240, 67);
            this.buttonAtualizarPratos.TabIndex = 7;
            this.buttonAtualizarPratos.Text = "Atualizar";
            this.buttonAtualizarPratos.UseVisualStyleBackColor = false;
            this.buttonAtualizarPratos.Click += new System.EventHandler(this.buttonatualizar_Click);
            // 
            // buttonAdicionarNovoPrato
            // 
            this.buttonAdicionarNovoPrato.BackColor = System.Drawing.Color.Blue;
            this.buttonAdicionarNovoPrato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdicionarNovoPrato.Location = new System.Drawing.Point(923, 948);
            this.buttonAdicionarNovoPrato.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAdicionarNovoPrato.Name = "buttonAdicionarNovoPrato";
            this.buttonAdicionarNovoPrato.Size = new System.Drawing.Size(240, 67);
            this.buttonAdicionarNovoPrato.TabIndex = 8;
            this.buttonAdicionarNovoPrato.Text = "Adicionar";
            this.buttonAdicionarNovoPrato.UseVisualStyleBackColor = false;
            this.buttonAdicionarNovoPrato.Click += new System.EventHandler(this.buttonadicionar_Click);
            // 
            // buttonEliminarPratos
            // 
            this.buttonEliminarPratos.BackColor = System.Drawing.Color.Blue;
            this.buttonEliminarPratos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEliminarPratos.Location = new System.Drawing.Point(444, 964);
            this.buttonEliminarPratos.Margin = new System.Windows.Forms.Padding(6);
            this.buttonEliminarPratos.Name = "buttonEliminarPratos";
            this.buttonEliminarPratos.Size = new System.Drawing.Size(240, 67);
            this.buttonEliminarPratos.TabIndex = 9;
            this.buttonEliminarPratos.Text = "Eliminar";
            this.buttonEliminarPratos.UseVisualStyleBackColor = false;
            this.buttonEliminarPratos.Click += new System.EventHandler(this.buttonEliminarPratos_Click);
            // 
            // labelAdicionarNovoPrato
            // 
            this.labelAdicionarNovoPrato.AutoSize = true;
            this.labelAdicionarNovoPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdicionarNovoPrato.Location = new System.Drawing.Point(753, 322);
            this.labelAdicionarNovoPrato.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAdicionarNovoPrato.Name = "labelAdicionarNovoPrato";
            this.labelAdicionarNovoPrato.Size = new System.Drawing.Size(478, 55);
            this.labelAdicionarNovoPrato.TabIndex = 10;
            this.labelAdicionarNovoPrato.Text = "Adicionar Novo Prato";
            this.labelAdicionarNovoPrato.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelDescricaoNovoPrato
            // 
            this.labelDescricaoNovoPrato.AutoSize = true;
            this.labelDescricaoNovoPrato.Location = new System.Drawing.Point(758, 448);
            this.labelDescricaoNovoPrato.Name = "labelDescricaoNovoPrato";
            this.labelDescricaoNovoPrato.Size = new System.Drawing.Size(114, 25);
            this.labelDescricaoNovoPrato.TabIndex = 11;
            this.labelDescricaoNovoPrato.Text = "Descrição:";
            this.labelDescricaoNovoPrato.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTipoNovoPrato
            // 
            this.labelTipoNovoPrato.AutoSize = true;
            this.labelTipoNovoPrato.Location = new System.Drawing.Point(758, 546);
            this.labelTipoNovoPrato.Name = "labelTipoNovoPrato";
            this.labelTipoNovoPrato.Size = new System.Drawing.Size(60, 25);
            this.labelTipoNovoPrato.TabIndex = 12;
            this.labelTipoNovoPrato.Text = "Tipo:";
            // 
            // textBoxDescricaoNovoPrato
            // 
            this.textBoxDescricaoNovoPrato.Location = new System.Drawing.Point(888, 448);
            this.textBoxDescricaoNovoPrato.Name = "textBoxDescricaoNovoPrato";
            this.textBoxDescricaoNovoPrato.Size = new System.Drawing.Size(326, 31);
            this.textBoxDescricaoNovoPrato.TabIndex = 14;
            this.textBoxDescricaoNovoPrato.TextChanged += new System.EventHandler(this.textBoxNomeNovoPrato_TextChanged);
            // 
            // textBoxTipoNovoPrato
            // 
            this.textBoxTipoNovoPrato.Location = new System.Drawing.Point(824, 546);
            this.textBoxTipoNovoPrato.Name = "textBoxTipoNovoPrato";
            this.textBoxTipoNovoPrato.Size = new System.Drawing.Size(326, 31);
            this.textBoxTipoNovoPrato.TabIndex = 15;
            // 
            // buttonCarregarPratos
            // 
            this.buttonCarregarPratos.BackColor = System.Drawing.Color.Blue;
            this.buttonCarregarPratos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCarregarPratos.Location = new System.Drawing.Point(15, 964);
            this.buttonCarregarPratos.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCarregarPratos.Name = "buttonCarregarPratos";
            this.buttonCarregarPratos.Size = new System.Drawing.Size(240, 67);
            this.buttonCarregarPratos.TabIndex = 19;
            this.buttonCarregarPratos.Text = "Carregar";
            this.buttonCarregarPratos.UseVisualStyleBackColor = false;
            this.buttonCarregarPratos.Click += new System.EventHandler(this.buttonCarregarPratos_Click);
            // 
            // textBoxTipoAtualizarPrato
            // 
            this.textBoxTipoAtualizarPrato.Location = new System.Drawing.Point(1476, 546);
            this.textBoxTipoAtualizarPrato.Name = "textBoxTipoAtualizarPrato";
            this.textBoxTipoAtualizarPrato.Size = new System.Drawing.Size(326, 31);
            this.textBoxTipoAtualizarPrato.TabIndex = 25;
            this.textBoxTipoAtualizarPrato.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxDescricaoAtualizarPrato
            // 
            this.textBoxDescricaoAtualizarPrato.Location = new System.Drawing.Point(1540, 448);
            this.textBoxDescricaoAtualizarPrato.Name = "textBoxDescricaoAtualizarPrato";
            this.textBoxDescricaoAtualizarPrato.Size = new System.Drawing.Size(326, 31);
            this.textBoxDescricaoAtualizarPrato.TabIndex = 24;
            this.textBoxDescricaoAtualizarPrato.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelTipoAtualizarPrato
            // 
            this.labelTipoAtualizarPrato.AutoSize = true;
            this.labelTipoAtualizarPrato.Location = new System.Drawing.Point(1410, 546);
            this.labelTipoAtualizarPrato.Name = "labelTipoAtualizarPrato";
            this.labelTipoAtualizarPrato.Size = new System.Drawing.Size(60, 25);
            this.labelTipoAtualizarPrato.TabIndex = 23;
            this.labelTipoAtualizarPrato.Text = "Tipo:";
            this.labelTipoAtualizarPrato.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelDescricaoAtualizarPrato
            // 
            this.labelDescricaoAtualizarPrato.AutoSize = true;
            this.labelDescricaoAtualizarPrato.Location = new System.Drawing.Point(1410, 448);
            this.labelDescricaoAtualizarPrato.Name = "labelDescricaoAtualizarPrato";
            this.labelDescricaoAtualizarPrato.Size = new System.Drawing.Size(114, 25);
            this.labelDescricaoAtualizarPrato.TabIndex = 22;
            this.labelDescricaoAtualizarPrato.Text = "Descrição:";
            this.labelDescricaoAtualizarPrato.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // labelAtualizarPrato
            // 
            this.labelAtualizarPrato.AutoSize = true;
            this.labelAtualizarPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtualizarPrato.Location = new System.Drawing.Point(1405, 322);
            this.labelAtualizarPrato.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAtualizarPrato.Name = "labelAtualizarPrato";
            this.labelAtualizarPrato.Size = new System.Drawing.Size(338, 55);
            this.labelAtualizarPrato.TabIndex = 21;
            this.labelAtualizarPrato.Text = "Atualizar Prato";
            this.labelAtualizarPrato.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxAtivoNovoPrato
            // 
            this.textBoxAtivoNovoPrato.Location = new System.Drawing.Point(1058, 642);
            this.textBoxAtivoNovoPrato.Name = "textBoxAtivoNovoPrato";
            this.textBoxAtivoNovoPrato.Size = new System.Drawing.Size(208, 31);
            this.textBoxAtivoNovoPrato.TabIndex = 42;
            this.textBoxAtivoNovoPrato.TextChanged += new System.EventHandler(this.textBoxAtivoNovoPrato_TextChanged);
            // 
            // labelAtivoNovoPrato
            // 
            this.labelAtivoNovoPrato.AutoSize = true;
            this.labelAtivoNovoPrato.Location = new System.Drawing.Point(758, 642);
            this.labelAtivoNovoPrato.Name = "labelAtivoNovoPrato";
            this.labelAtivoNovoPrato.Size = new System.Drawing.Size(294, 25);
            this.labelAtivoNovoPrato.TabIndex = 41;
            this.labelAtivoNovoPrato.Text = "O extra está ativo? (Sim/Não)";
            // 
            // textBoxAtivoAtualizarPrato
            // 
            this.textBoxAtivoAtualizarPrato.Location = new System.Drawing.Point(1710, 648);
            this.textBoxAtivoAtualizarPrato.Name = "textBoxAtivoAtualizarPrato";
            this.textBoxAtivoAtualizarPrato.Size = new System.Drawing.Size(152, 31);
            this.textBoxAtivoAtualizarPrato.TabIndex = 44;
            this.textBoxAtivoAtualizarPrato.TextChanged += new System.EventHandler(this.textBoxAtivoAtualizarPrato_TextChanged);
            // 
            // labelAtivoAtualizarPrato
            // 
            this.labelAtivoAtualizarPrato.AutoSize = true;
            this.labelAtivoAtualizarPrato.Location = new System.Drawing.Point(1410, 648);
            this.labelAtivoAtualizarPrato.Name = "labelAtivoAtualizarPrato";
            this.labelAtivoAtualizarPrato.Size = new System.Drawing.Size(294, 25);
            this.labelAtivoAtualizarPrato.TabIndex = 43;
            this.labelAtivoAtualizarPrato.Text = "O extra está ativo? (Sim/Não)";
            // 
            // pratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1938, 1086);
            this.Controls.Add(this.textBoxAtivoAtualizarPrato);
            this.Controls.Add(this.labelAtivoAtualizarPrato);
            this.Controls.Add(this.textBoxAtivoNovoPrato);
            this.Controls.Add(this.labelAtivoNovoPrato);
            this.Controls.Add(this.textBoxTipoAtualizarPrato);
            this.Controls.Add(this.textBoxDescricaoAtualizarPrato);
            this.Controls.Add(this.labelTipoAtualizarPrato);
            this.Controls.Add(this.labelDescricaoAtualizarPrato);
            this.Controls.Add(this.labelAtualizarPrato);
            this.Controls.Add(this.buttonCarregarPratos);
            this.Controls.Add(this.textBoxTipoNovoPrato);
            this.Controls.Add(this.textBoxDescricaoNovoPrato);
            this.Controls.Add(this.labelTipoNovoPrato);
            this.Controls.Add(this.labelDescricaoNovoPrato);
            this.Controls.Add(this.labelAdicionarNovoPrato);
            this.Controls.Add(this.buttonEliminarPratos);
            this.Controls.Add(this.buttonAdicionarNovoPrato);
            this.Controls.Add(this.buttonAtualizarPratos);
            this.Controls.Add(this.labelListaDePratos);
            this.Controls.Add(this.listBoxPratos);
            this.Controls.Add(this.labelMenuDePratos);
            this.Controls.Add(this.textBoxpratos);
            this.Controls.Add(this.pictureBoxICantina);
            this.Name = "pratos";
            this.Text = "pratos";
            this.Load += new System.EventHandler(this.pratos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxICantina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxICantina;
        private System.Windows.Forms.TextBox textBoxpratos;
        private System.Windows.Forms.Label labelMenuDePratos;
        private System.Windows.Forms.ListBox listBoxPratos;
        private System.Windows.Forms.Label labelListaDePratos;
        private System.Windows.Forms.Button buttonAtualizarPratos;
        private System.Windows.Forms.Button buttonAdicionarNovoPrato;
        private System.Windows.Forms.Button buttonEliminarPratos;
        private System.Windows.Forms.Label labelAdicionarNovoPrato;
        private System.Windows.Forms.Label labelDescricaoNovoPrato;
        private System.Windows.Forms.Label labelTipoNovoPrato;
        private System.Windows.Forms.TextBox textBoxDescricaoNovoPrato;
        private System.Windows.Forms.TextBox textBoxTipoNovoPrato;
        private System.Windows.Forms.Button buttonCarregarPratos;
        private System.Windows.Forms.TextBox textBoxTipoAtualizarPrato;
        private System.Windows.Forms.TextBox textBoxDescricaoAtualizarPrato;
        private System.Windows.Forms.Label labelTipoAtualizarPrato;
        private System.Windows.Forms.Label labelDescricaoAtualizarPrato;
        private System.Windows.Forms.Label labelAtualizarPrato;
        private System.Windows.Forms.TextBox textBoxAtivoNovoPrato;
        private System.Windows.Forms.Label labelAtivoNovoPrato;
        private System.Windows.Forms.TextBox textBoxAtivoAtualizarPrato;
        private System.Windows.Forms.Label labelAtivoAtualizarPrato;
    }
}