namespace Projeto.view
{
    partial class menus
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
            this.monthCalendar1.Location = new System.Drawing.Point(17, 28);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // Alterarpratoseextras
            // 
            this.Alterarpratoseextras.BackColor = System.Drawing.Color.Blue;
            this.Alterarpratoseextras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Alterarpratoseextras.Location = new System.Drawing.Point(16, 254);
            this.Alterarpratoseextras.Margin = new System.Windows.Forms.Padding(4);
            this.Alterarpratoseextras.Name = "Alterarpratoseextras";
            this.Alterarpratoseextras.Size = new System.Drawing.Size(303, 49);
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
            this.groupBoxmenudodia.Location = new System.Drawing.Point(436, 28);
            this.groupBoxmenudodia.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxmenudodia.Name = "groupBoxmenudodia";
            this.groupBoxmenudodia.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxmenudodia.Size = new System.Drawing.Size(800, 274);
            this.groupBoxmenudodia.TabIndex = 2;
            this.groupBoxmenudodia.TabStop = false;
            this.groupBoxmenudodia.Text = "Menu do dia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Extras";
            // 
            // listBoxextras
            // 
            this.listBoxextras.FormattingEnabled = true;
            this.listBoxextras.ItemHeight = 16;
            this.listBoxextras.Location = new System.Drawing.Point(469, 54);
            this.listBoxextras.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxextras.Name = "listBoxextras";
            this.listBoxextras.Size = new System.Drawing.Size(220, 212);
            this.listBoxextras.TabIndex = 2;
            // 
            // labelpratos
            // 
            this.labelpratos.AutoSize = true;
            this.labelpratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpratos.Location = new System.Drawing.Point(43, 28);
            this.labelpratos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpratos.Name = "labelpratos";
            this.labelpratos.Size = new System.Drawing.Size(62, 24);
            this.labelpratos.TabIndex = 1;
            this.labelpratos.Text = "Pratos";
            // 
            // listBoxpratos
            // 
            this.listBoxpratos.FormattingEnabled = true;
            this.listBoxpratos.ItemHeight = 16;
            this.listBoxpratos.Location = new System.Drawing.Point(47, 54);
            this.listBoxpratos.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxpratos.Name = "listBoxpratos";
            this.listBoxpratos.Size = new System.Drawing.Size(220, 212);
            this.listBoxpratos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonsalvar);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(17, 342);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1259, 338);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Pratos ou extras";
            this.groupBox1.Visible = false;
            // 
            // buttonsalvar
            // 
            this.buttonsalvar.BackColor = System.Drawing.Color.Blue;
            this.buttonsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsalvar.Location = new System.Drawing.Point(857, 140);
            this.buttonsalvar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsalvar.Name = "buttonsalvar";
            this.buttonsalvar.Size = new System.Drawing.Size(303, 49);
            this.buttonsalvar.TabIndex = 4;
            this.buttonsalvar.Text = "Salvar Alterações";
            this.buttonsalvar.UseVisualStyleBackColor = false;
            this.buttonsalvar.Click += new System.EventHandler(this.buttonsalvar_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(469, 74);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(220, 212);
            this.listBox2.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(47, 74);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 212);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pratos";
            // 
            // menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 695);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxmenudodia);
            this.Controls.Add(this.Alterarpratoseextras);
            this.Controls.Add(this.monthCalendar1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menus";
            this.Text = "menu";
            this.groupBoxmenudodia.ResumeLayout(false);
            this.groupBoxmenudodia.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}