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
            this.buttonSelecionarPratos = new System.Windows.Forms.Button();
            this.buttonAtualizarPratos = new System.Windows.Forms.Button();
            this.buttonAdicionarNovoPrato = new System.Windows.Forms.Button();
            this.buttonEliminarPratos = new System.Windows.Forms.Button();
            this.labelAdicionarNovoPrato = new System.Windows.Forms.Label();
            this.labelNomeNovoPrato = new System.Windows.Forms.Label();
            this.labelTipoNovoPrato = new System.Windows.Forms.Label();
            this.labelQuantidadeInicialNovoPrato = new System.Windows.Forms.Label();
            this.textBoxNomeNovoPrato = new System.Windows.Forms.TextBox();
            this.textBoxTipoNovoPrato = new System.Windows.Forms.TextBox();
            this.textBoxQuantidadeInicialNovoPrato = new System.Windows.Forms.TextBox();
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
            this.listBoxPratos.Size = new System.Drawing.Size(952, 554);
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
            // buttonSelecionarPratos
            // 
            this.buttonSelecionarPratos.BackColor = System.Drawing.Color.Blue;
            this.buttonSelecionarPratos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelecionarPratos.Location = new System.Drawing.Point(20, 964);
            this.buttonSelecionarPratos.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSelecionarPratos.Name = "buttonSelecionarPratos";
            this.buttonSelecionarPratos.Size = new System.Drawing.Size(300, 56);
            this.buttonSelecionarPratos.TabIndex = 6;
            this.buttonSelecionarPratos.Text = "Selecionar";
            this.buttonSelecionarPratos.UseVisualStyleBackColor = false;
            // 
            // buttonAtualizarPratos
            // 
            this.buttonAtualizarPratos.BackColor = System.Drawing.Color.Blue;
            this.buttonAtualizarPratos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAtualizarPratos.Location = new System.Drawing.Point(444, 964);
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
            this.buttonAdicionarNovoPrato.Location = new System.Drawing.Point(1462, 953);
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
            this.buttonEliminarPratos.Location = new System.Drawing.Point(732, 964);
            this.buttonEliminarPratos.Margin = new System.Windows.Forms.Padding(6);
            this.buttonEliminarPratos.Name = "buttonEliminarPratos";
            this.buttonEliminarPratos.Size = new System.Drawing.Size(240, 67);
            this.buttonEliminarPratos.TabIndex = 9;
            this.buttonEliminarPratos.Text = "Eliminar";
            this.buttonEliminarPratos.UseVisualStyleBackColor = false;
            // 
            // labelAdicionarNovoPrato
            // 
            this.labelAdicionarNovoPrato.AutoSize = true;
            this.labelAdicionarNovoPrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdicionarNovoPrato.Location = new System.Drawing.Point(1292, 327);
            this.labelAdicionarNovoPrato.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAdicionarNovoPrato.Name = "labelAdicionarNovoPrato";
            this.labelAdicionarNovoPrato.Size = new System.Drawing.Size(478, 55);
            this.labelAdicionarNovoPrato.TabIndex = 10;
            this.labelAdicionarNovoPrato.Text = "Adicionar Novo Prato";
            this.labelAdicionarNovoPrato.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelNomeNovoPrato
            // 
            this.labelNomeNovoPrato.AutoSize = true;
            this.labelNomeNovoPrato.Location = new System.Drawing.Point(1297, 453);
            this.labelNomeNovoPrato.Name = "labelNomeNovoPrato";
            this.labelNomeNovoPrato.Size = new System.Drawing.Size(74, 25);
            this.labelNomeNovoPrato.TabIndex = 11;
            this.labelNomeNovoPrato.Text = "Nome:";
            this.labelNomeNovoPrato.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTipoNovoPrato
            // 
            this.labelTipoNovoPrato.AutoSize = true;
            this.labelTipoNovoPrato.Location = new System.Drawing.Point(1297, 551);
            this.labelTipoNovoPrato.Name = "labelTipoNovoPrato";
            this.labelTipoNovoPrato.Size = new System.Drawing.Size(60, 25);
            this.labelTipoNovoPrato.TabIndex = 12;
            this.labelTipoNovoPrato.Text = "Tipo:";
            // 
            // labelQuantidadeInicialNovoPrato
            // 
            this.labelQuantidadeInicialNovoPrato.AutoSize = true;
            this.labelQuantidadeInicialNovoPrato.Location = new System.Drawing.Point(1297, 660);
            this.labelQuantidadeInicialNovoPrato.Name = "labelQuantidadeInicialNovoPrato";
            this.labelQuantidadeInicialNovoPrato.Size = new System.Drawing.Size(190, 25);
            this.labelQuantidadeInicialNovoPrato.TabIndex = 13;
            this.labelQuantidadeInicialNovoPrato.Text = "Quantidade Inicial:";
            // 
            // textBoxNomeNovoPrato
            // 
            this.textBoxNomeNovoPrato.Location = new System.Drawing.Point(1386, 453);
            this.textBoxNomeNovoPrato.Name = "textBoxNomeNovoPrato";
            this.textBoxNomeNovoPrato.Size = new System.Drawing.Size(326, 31);
            this.textBoxNomeNovoPrato.TabIndex = 14;
            // 
            // textBoxTipoNovoPrato
            // 
            this.textBoxTipoNovoPrato.Location = new System.Drawing.Point(1376, 551);
            this.textBoxTipoNovoPrato.Name = "textBoxTipoNovoPrato";
            this.textBoxTipoNovoPrato.Size = new System.Drawing.Size(326, 31);
            this.textBoxTipoNovoPrato.TabIndex = 15;
            // 
            // textBoxQuantidadeInicialNovoPrato
            // 
            this.textBoxQuantidadeInicialNovoPrato.Location = new System.Drawing.Point(1504, 660);
            this.textBoxQuantidadeInicialNovoPrato.Name = "textBoxQuantidadeInicialNovoPrato";
            this.textBoxQuantidadeInicialNovoPrato.Size = new System.Drawing.Size(326, 31);
            this.textBoxQuantidadeInicialNovoPrato.TabIndex = 16;
            // 
            // pratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1938, 1086);
            this.Controls.Add(this.textBoxQuantidadeInicialNovoPrato);
            this.Controls.Add(this.textBoxTipoNovoPrato);
            this.Controls.Add(this.textBoxNomeNovoPrato);
            this.Controls.Add(this.labelQuantidadeInicialNovoPrato);
            this.Controls.Add(this.labelTipoNovoPrato);
            this.Controls.Add(this.labelNomeNovoPrato);
            this.Controls.Add(this.labelAdicionarNovoPrato);
            this.Controls.Add(this.buttonEliminarPratos);
            this.Controls.Add(this.buttonAdicionarNovoPrato);
            this.Controls.Add(this.buttonAtualizarPratos);
            this.Controls.Add(this.buttonSelecionarPratos);
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
        private System.Windows.Forms.Button buttonSelecionarPratos;
        private System.Windows.Forms.Button buttonAtualizarPratos;
        private System.Windows.Forms.Button buttonAdicionarNovoPrato;
        private System.Windows.Forms.Button buttonEliminarPratos;
        private System.Windows.Forms.Label labelAdicionarNovoPrato;
        private System.Windows.Forms.Label labelNomeNovoPrato;
        private System.Windows.Forms.Label labelTipoNovoPrato;
        private System.Windows.Forms.Label labelQuantidadeInicialNovoPrato;
        private System.Windows.Forms.TextBox textBoxNomeNovoPrato;
        private System.Windows.Forms.TextBox textBoxTipoNovoPrato;
        private System.Windows.Forms.TextBox textBoxQuantidadeInicialNovoPrato;
    }
}