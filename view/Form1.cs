using Projeto.modelos;
using Projeto.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonfuncionarios_Click(object sender, EventArgs e)
        {
            funcionarios func = new funcionarios();
            func.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonreservas_Click(object sender, EventArgs e)
        {
            reservas func = new reservas();
            func.Show();
            this.Hide();
        }

        private void buttonclientes_Click(object sender, EventArgs e)
        {
            cliente func = new cliente();
            func.Show();
            this.Hide();
        }

        private void buttonpratos_Click(object sender, EventArgs e)
        {

        }

        private void buttonextras_Click(object sender, EventArgs e)
        {

        }

        private void buttonmenu_Click(object sender, EventArgs e)
        {
            menus func = new menus();
            func.Show();
            this.Hide();
        }

        private void buttonmultas_Click(object sender, EventArgs e)
        {
            multas func = new multas();
            func.Show();
            this.Hide();
        }
    }
}
