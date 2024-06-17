using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.modelos
{
    public partial class multas : Form
    {
        public multas()
        {
            InitializeComponent();
        }

        private void buttonvoltar_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            this.Close();
        }

        private void buttonatualizarCliente_Click(object sender, EventArgs e)
        {

        }


        private void buttoncriarmulta_Click(object sender, EventArgs e)
        {

        }

        private void buttonapagarMulta_Click(object sender, EventArgs e)
        {

        }
    }
}
