using Projeto.controller;
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
        private multascontroller _multasController;
        private maincontroller _mainController;
        public multas()
        {
            InitializeComponent();
            InicializarControladores();
            CarregarMultas();
        }

        private void InicializarControladores()
        {
            _mainController = new maincontroller();
            _multasController = new multascontroller(_mainController);
        }
        private void buttonvoltar_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            this.Close();
        }


        private void buttoncriarmulta_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void buttonapagarMulta_Click(object sender, EventArgs e)
        {

        }

        private void buttonsalvarMulta_Click(object sender, EventArgs e)
        {
            float valor = ((float)numericUpDownmultaatraso.Value);
            float num_horas = ((float)numericUpDowntempoatraso.Value);

            _multasController.AdicionarMulta(valor, num_horas);
            MessageBox.Show("Multa adicionada com sucesso");
            CarregarMultas();
        }

        private void CarregarMultas()
        {
            try
            {
                if (_mainController != null)
                {
                    List<multa> multas = _mainController.ObterMultas();

                    listBoxmultas.Items.Clear();

                    foreach (var multa in multas)
                    {
                        listBoxmultas.Items.Add($"{multa.valor}");
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao carregar multas: Main controller é NULL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar multas: {ex.Message}");
            }
        }
    }
}
