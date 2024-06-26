using Projeto.controller;
using Projeto.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data.Entity;

namespace Projeto
{
    public partial class funcionarios : Form
    {
        public funcionarios()
        {
            InitializeComponent();
        

        }

        private void buttonvoltar_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            this.Close();
        }

        private void buttoncriarfuncionario_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            var funcionario = new funcionario
            {
                nome = textBoxinserirNome.Text,
                nif = textBoxinserirNif.Text,
                username = textBoxusername.Text,
            };
        }

      
    }
}
