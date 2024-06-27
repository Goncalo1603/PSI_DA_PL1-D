namespace Projeto.view
{
<<<<<<< Updated upstream
    partial class menu
=======
    partial class menus
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Alterarpratoseextras = new System.Windows.Forms.Button();
            this.groupBoxmenudodia = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxextras = new System.Windows.Forms.ListBox();
            this.labelpratos = new System.Windows.Forms.Label();
            this.listBoxpratos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonsalvar = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxmenudodia.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(26, 44);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // Alterarpratoseextras
            // 
            this.Alterarpratoseextras.BackColor = System.Drawing.Color.Blue;
            this.Alterarpratoseextras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Alterarpratoseextras.Location = new System.Drawing.Point(24, 396);
            this.Alterarpratoseextras.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Alterarpratoseextras.Name = "Alterarpratoseextras";
            this.Alterarpratoseextras.Size = new System.Drawing.Size(454, 77);
            this.Alterarpratoseextras.TabIndex = 1;
            this.Alterarpratoseextras.Text = "Alterar Pratos/Extras";
            this.Alterarpratoseextras.UseVisualStyleBackColor = false;
            this.Alterarpratoseextras.Click += new System.EventHandler(this.Alterarpratoseextras_Click);
            // 
            // groupBoxmenudodia
            // 
            this.groupBoxmenudodia.Controls.Add(this.label1);
            this.groupBoxmenudodia.Controls.Add(this.listBoxextras);
            this.groupBoxmenudodia.Controls.Add(this.labelpratos);
            this.groupBoxmenudodia.Controls.Add(this.listBoxpratos);
            this.groupBoxmenudodia.Location = new System.Drawing.Point(654, 44);
            this.groupBoxmenudodia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxmenudodia.Name = "groupBoxmenudodia";
            this.groupBoxmenudodia.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxmenudodia.Size = new System.Drawing.Size(1200, 429);
            this.groupBoxmenudodia.TabIndex = 2;
            this.groupBoxmenudodia.TabStop = false;
            this.groupBoxmenudodia.Text = "Menu do dia";
=======
            this.label5 = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.buttonsalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPrecoAln = new System.Windows.Forms.Label();
            this.labelPrecoProf = new System.Windows.Forms.Label();
            this.labelQtdDisp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxextras = new System.Windows.Forms.ListBox();
            this.labelpratos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonvoltar = new System.Windows.Forms.Button();
            this.listBoxpratos = new System.Windows.Forms.ListBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.numericUpDownPrecoProf = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrecoAl = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownQtd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxmenudodia = new System.Windows.Forms.GroupBox();
            this.Alterarpratoseextras = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecoProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecoAl)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtd)).BeginInit();
            this.groupBoxmenudodia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Preço Aluno";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.Location = new System.Drawing.Point(428, 76);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(155, 18);
            this.labelQuantidade.TabIndex = 7;
            this.labelQuantidade.Text = "Quantidade Disponível";
            // 
            // buttonsalvar
            // 
            this.buttonsalvar.BackColor = System.Drawing.Color.Blue;
            this.buttonsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsalvar.Location = new System.Drawing.Point(645, 76);
            this.buttonsalvar.Name = "buttonsalvar";
            this.buttonsalvar.Size = new System.Drawing.Size(227, 40);
            this.buttonsalvar.TabIndex = 4;
            this.buttonsalvar.Text = "Salvar Alterações";
            this.buttonsalvar.UseVisualStyleBackColor = false;
            this.buttonsalvar.Click += new System.EventHandler(this.buttonsalvar_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(534, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Apagar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelPrecoAln
            // 
            this.labelPrecoAln.AutoSize = true;
            this.labelPrecoAln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoAln.Location = new System.Drawing.Point(397, 172);
            this.labelPrecoAln.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecoAln.Name = "labelPrecoAln";
            this.labelPrecoAln.Size = new System.Drawing.Size(30, 17);
            this.labelPrecoAln.TabIndex = 17;
            this.labelPrecoAln.Text = "null";
            // 
            // labelPrecoProf
            // 
            this.labelPrecoProf.AutoSize = true;
            this.labelPrecoProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoProf.Location = new System.Drawing.Point(397, 124);
            this.labelPrecoProf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecoProf.Name = "labelPrecoProf";
            this.labelPrecoProf.Size = new System.Drawing.Size(30, 17);
            this.labelPrecoProf.TabIndex = 16;
            this.labelPrecoProf.Text = "null";
            // 
            // labelQtdDisp
            // 
            this.labelQtdDisp.AutoSize = true;
            this.labelQtdDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtdDisp.Location = new System.Drawing.Point(397, 73);
            this.labelQtdDisp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQtdDisp.Name = "labelQtdDisp";
            this.labelQtdDisp.Size = new System.Drawing.Size(30, 17);
            this.labelQtdDisp.TabIndex = 15;
            this.labelQtdDisp.Text = "null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Preço Aluno";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(237, 60);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(166, 173);
            this.listBox2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(397, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Preço Professor";
>>>>>>> Stashed changes
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< Updated upstream
            this.label1.Location = new System.Drawing.Point(698, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
=======
            this.label1.Location = new System.Drawing.Point(214, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
>>>>>>> Stashed changes
            this.label1.TabIndex = 3;
            this.label1.Text = "Extras";
            // 
            // listBoxextras
            // 
            this.listBoxextras.FormattingEnabled = true;
<<<<<<< Updated upstream
            this.listBoxextras.ItemHeight = 25;
            this.listBoxextras.Location = new System.Drawing.Point(704, 85);
            this.listBoxextras.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxextras.Name = "listBoxextras";
            this.listBoxextras.Size = new System.Drawing.Size(328, 329);
=======
            this.listBoxextras.Location = new System.Drawing.Point(218, 44);
            this.listBoxextras.Name = "listBoxextras";
            this.listBoxextras.Size = new System.Drawing.Size(166, 173);
>>>>>>> Stashed changes
            this.listBoxextras.TabIndex = 2;
            // 
            // labelpratos
            // 
            this.labelpratos.AutoSize = true;
            this.labelpratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< Updated upstream
            this.labelpratos.Location = new System.Drawing.Point(64, 44);
            this.labelpratos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelpratos.Name = "labelpratos";
            this.labelpratos.Size = new System.Drawing.Size(101, 36);
            this.labelpratos.TabIndex = 1;
            this.labelpratos.Text = "Pratos";
            // 
            // listBoxpratos
            // 
            this.listBoxpratos.FormattingEnabled = true;
            this.listBoxpratos.ItemHeight = 25;
            this.listBoxpratos.Location = new System.Drawing.Point(70, 85);
            this.listBoxpratos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxpratos.Name = "listBoxpratos";
            this.listBoxpratos.Size = new System.Drawing.Size(328, 329);
            this.listBoxpratos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonsalvar);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(26, 535);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1888, 529);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Pratos ou extras";
            // 
            // buttonsalvar
            // 
            this.buttonsalvar.BackColor = System.Drawing.Color.Blue;
            this.buttonsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsalvar.Location = new System.Drawing.Point(1286, 219);
            this.buttonsalvar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonsalvar.Name = "buttonsalvar";
            this.buttonsalvar.Size = new System.Drawing.Size(454, 77);
            this.buttonsalvar.TabIndex = 4;
            this.buttonsalvar.Text = "Salvar Alterações";
            this.buttonsalvar.UseVisualStyleBackColor = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(704, 115);
            this.listBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(328, 329);
            this.listBox2.TabIndex = 5;
=======
            this.labelpratos.Location = new System.Drawing.Point(32, 23);
            this.labelpratos.Name = "labelpratos";
            this.labelpratos.Size = new System.Drawing.Size(52, 18);
            this.labelpratos.TabIndex = 1;
            this.labelpratos.Text = "Pratos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preço Professor";
>>>>>>> Stashed changes
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
<<<<<<< Updated upstream
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(70, 115);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 329);
=======
            this.listBox1.Location = new System.Drawing.Point(35, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 173);
>>>>>>> Stashed changes
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< Updated upstream
            this.label2.Location = new System.Drawing.Point(698, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extras";
            // 
=======
            this.label2.Location = new System.Drawing.Point(234, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(397, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Quantidade Disponível";
            // 
            // buttonvoltar
            // 
            this.buttonvoltar.BackColor = System.Drawing.Color.Blue;
            this.buttonvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonvoltar.Location = new System.Drawing.Point(38, 6);
            this.buttonvoltar.Name = "buttonvoltar";
            this.buttonvoltar.Size = new System.Drawing.Size(150, 22);
            this.buttonvoltar.TabIndex = 20;
            this.buttonvoltar.Text = "Voltar";
            this.buttonvoltar.UseVisualStyleBackColor = false;
            this.buttonvoltar.Click += new System.EventHandler(this.buttonvoltar_Click_1);
            // 
            // listBoxpratos
            // 
            this.listBoxpratos.FormattingEnabled = true;
            this.listBoxpratos.Location = new System.Drawing.Point(35, 44);
            this.listBoxpratos.Name = "listBoxpratos";
            this.listBoxpratos.Size = new System.Drawing.Size(166, 173);
            this.listBoxpratos.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Blue;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Location = new System.Drawing.Point(645, 150);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(227, 40);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click_1);
            // 
            // numericUpDownPrecoProf
            // 
            this.numericUpDownPrecoProf.DecimalPlaces = 2;
            this.numericUpDownPrecoProf.Location = new System.Drawing.Point(431, 197);
            this.numericUpDownPrecoProf.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPrecoProf.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownPrecoProf.Name = "numericUpDownPrecoProf";
            this.numericUpDownPrecoProf.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownPrecoProf.TabIndex = 14;
            // 
            // numericUpDownPrecoAl
            // 
            this.numericUpDownPrecoAl.DecimalPlaces = 2;
            this.numericUpDownPrecoAl.Location = new System.Drawing.Point(431, 150);
            this.numericUpDownPrecoAl.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPrecoAl.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownPrecoAl.Name = "numericUpDownPrecoAl";
            this.numericUpDownPrecoAl.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownPrecoAl.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.numericUpDownPrecoProf);
            this.groupBox1.Controls.Add(this.numericUpDownPrecoAl);
            this.groupBox1.Controls.Add(this.numericUpDownQtd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelQuantidade);
            this.groupBox1.Controls.Add(this.buttonsalvar);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 275);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Pratos ou extras";
            this.groupBox1.Visible = false;
            // 
            // numericUpDownQtd
            // 
            this.numericUpDownQtd.Location = new System.Drawing.Point(431, 99);
            this.numericUpDownQtd.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownQtd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQtd.Name = "numericUpDownQtd";
            this.numericUpDownQtd.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownQtd.TabIndex = 12;
            this.numericUpDownQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
>>>>>>> Stashed changes
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< Updated upstream
            this.label3.Location = new System.Drawing.Point(64, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pratos";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1938, 1087);
=======
            this.label3.Location = new System.Drawing.Point(32, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pratos";
            // 
            // groupBoxmenudodia
            // 
            this.groupBoxmenudodia.Controls.Add(this.button1);
            this.groupBoxmenudodia.Controls.Add(this.labelPrecoAln);
            this.groupBoxmenudodia.Controls.Add(this.labelPrecoProf);
            this.groupBoxmenudodia.Controls.Add(this.labelQtdDisp);
            this.groupBoxmenudodia.Controls.Add(this.label6);
            this.groupBoxmenudodia.Controls.Add(this.label7);
            this.groupBoxmenudodia.Controls.Add(this.label8);
            this.groupBoxmenudodia.Controls.Add(this.label1);
            this.groupBoxmenudodia.Controls.Add(this.listBoxextras);
            this.groupBoxmenudodia.Controls.Add(this.labelpratos);
            this.groupBoxmenudodia.Controls.Add(this.listBoxpratos);
            this.groupBoxmenudodia.Location = new System.Drawing.Point(327, 29);
            this.groupBoxmenudodia.Name = "groupBoxmenudodia";
            this.groupBoxmenudodia.Size = new System.Drawing.Size(600, 223);
            this.groupBoxmenudodia.TabIndex = 18;
            this.groupBoxmenudodia.TabStop = false;
            this.groupBoxmenudodia.Text = "Menu do dia";
            // 
            // Alterarpratoseextras
            // 
            this.Alterarpratoseextras.BackColor = System.Drawing.Color.Blue;
            this.Alterarpratoseextras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Alterarpratoseextras.Location = new System.Drawing.Point(12, 212);
            this.Alterarpratoseextras.Name = "Alterarpratoseextras";
            this.Alterarpratoseextras.Size = new System.Drawing.Size(227, 40);
            this.Alterarpratoseextras.TabIndex = 17;
            this.Alterarpratoseextras.Text = "Alterar Pratos/Extras";
            this.Alterarpratoseextras.UseVisualStyleBackColor = false;
            this.Alterarpratoseextras.Click += new System.EventHandler(this.Alterarpratoseextras_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 29);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 565);
            this.Controls.Add(this.buttonvoltar);
>>>>>>> Stashed changes
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxmenudodia);
            this.Controls.Add(this.Alterarpratoseextras);
            this.Controls.Add(this.monthCalendar1);
<<<<<<< Updated upstream
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "menu";
            this.Text = "menu";
            this.groupBoxmenudodia.ResumeLayout(false);
            this.groupBoxmenudodia.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
=======
            this.Name = "menus";
            this.Text = "menu";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecoProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecoAl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtd)).EndInit();
            this.groupBoxmenudodia.ResumeLayout(false);
            this.groupBoxmenudodia.PerformLayout();
>>>>>>> Stashed changes
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< Updated upstream
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button Alterarpratoseextras;
        private System.Windows.Forms.GroupBox groupBoxmenudodia;
        private System.Windows.Forms.ListBox listBoxpratos;
        private System.Windows.Forms.Label labelpratos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxextras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonsalvar;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
=======
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Button buttonsalvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPrecoAln;
        private System.Windows.Forms.Label labelPrecoProf;
        private System.Windows.Forms.Label labelQtdDisp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxextras;
        private System.Windows.Forms.Label labelpratos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonvoltar;
        private System.Windows.Forms.ListBox listBoxpratos;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecoProf;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecoAl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownQtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxmenudodia;
        private System.Windows.Forms.Button Alterarpratoseextras;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
>>>>>>> Stashed changes
    }
}