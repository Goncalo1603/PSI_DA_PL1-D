namespace Projeto.view
{
    partial class menu
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
            this.listBoxpratos = new System.Windows.Forms.ListBox();
            this.labelpratos = new System.Windows.Forms.Label();
            this.listBoxextras = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonsalvar = new System.Windows.Forms.Button();
            this.groupBoxmenudodia.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 23);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // Alterarpratoseextras
            // 
            this.Alterarpratoseextras.BackColor = System.Drawing.Color.Blue;
            this.Alterarpratoseextras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Alterarpratoseextras.Location = new System.Drawing.Point(12, 206);
            this.Alterarpratoseextras.Name = "Alterarpratoseextras";
            this.Alterarpratoseextras.Size = new System.Drawing.Size(227, 40);
            this.Alterarpratoseextras.TabIndex = 1;
            this.Alterarpratoseextras.Text = "Alterar Pratos/Extras";
            this.Alterarpratoseextras.UseVisualStyleBackColor = false;
            // 
            // groupBoxmenudodia
            // 
            this.groupBoxmenudodia.Controls.Add(this.label1);
            this.groupBoxmenudodia.Controls.Add(this.listBoxextras);
            this.groupBoxmenudodia.Controls.Add(this.labelpratos);
            this.groupBoxmenudodia.Controls.Add(this.listBoxpratos);
            this.groupBoxmenudodia.Location = new System.Drawing.Point(327, 23);
            this.groupBoxmenudodia.Name = "groupBoxmenudodia";
            this.groupBoxmenudodia.Size = new System.Drawing.Size(600, 223);
            this.groupBoxmenudodia.TabIndex = 2;
            this.groupBoxmenudodia.TabStop = false;
            this.groupBoxmenudodia.Text = "Menu do dia";
            // 
            // listBoxpratos
            // 
            this.listBoxpratos.FormattingEnabled = true;
            this.listBoxpratos.Location = new System.Drawing.Point(35, 44);
            this.listBoxpratos.Name = "listBoxpratos";
            this.listBoxpratos.Size = new System.Drawing.Size(166, 173);
            this.listBoxpratos.TabIndex = 0;
            // 
            // labelpratos
            // 
            this.labelpratos.AutoSize = true;
            this.labelpratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpratos.Location = new System.Drawing.Point(32, 23);
            this.labelpratos.Name = "labelpratos";
            this.labelpratos.Size = new System.Drawing.Size(52, 18);
            this.labelpratos.TabIndex = 1;
            this.labelpratos.Text = "Pratos";
            // 
            // listBoxextras
            // 
            this.listBoxextras.FormattingEnabled = true;
            this.listBoxextras.Location = new System.Drawing.Point(352, 44);
            this.listBoxextras.Name = "listBoxextras";
            this.listBoxextras.Size = new System.Drawing.Size(166, 173);
            this.listBoxextras.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Extras";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonsalvar);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 275);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar Pratos ou extras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pratos";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 173);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(352, 60);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(166, 173);
            this.listBox2.TabIndex = 5;
            // 
            // buttonsalvar
            // 
            this.buttonsalvar.BackColor = System.Drawing.Color.Blue;
            this.buttonsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsalvar.Location = new System.Drawing.Point(643, 114);
            this.buttonsalvar.Name = "buttonsalvar";
            this.buttonsalvar.Size = new System.Drawing.Size(227, 40);
            this.buttonsalvar.TabIndex = 4;
            this.buttonsalvar.Text = "Salvar Alterações";
            this.buttonsalvar.UseVisualStyleBackColor = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxmenudodia);
            this.Controls.Add(this.Alterarpratoseextras);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "menu";
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