<<<<<<< Updated upstream
﻿using System;
=======
﻿using Projeto.controller;
using System;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        public multas()
        {
            InitializeComponent();
=======
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

        private void buttoncriarmulta_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            this.Close();
        }

        private void buttonatualizarCliente_Click(object sender, EventArgs e)
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

        private void listBoxmultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxmultas.SelectedItem != null)
            {
                string selectedMulta = listBoxmultas.SelectedItem.ToString();
                string[] multaDetails = selectedMulta.Split('-');

                float valor = Convert.ToSingle(multaDetails[0].Trim());

                multa multa = _mainController.ObterMultas().FirstOrDefault(f => f.valor == valor);

                // Exibir os detalhes da multa na GroupBox
                if (multa != null)
                {
                    groupBox1.Visible = true;
                    numericUpDownmultaatraso.Value = (decimal)multa.valor;
                    numericUpDowntempoatraso.Value = (decimal)multa.num_horas;
                }
            }
>>>>>>> Stashed changes
        }

        private void buttonapagarCliente_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream

=======
            if (listBoxmultas.SelectedItem != null)
            {
                string selectedMulta = listBoxmultas.SelectedItem.ToString();
                string[] multaDetails = selectedMulta.Split('-');

                float valor = Convert.ToSingle(multaDetails[0].Trim());

                multa multa = _mainController.ObterMultas().FirstOrDefault(f => f.valor == valor);

                if (selectedMulta != null)
                {
                    _mainController.RemoverMulta(multa);
                    MessageBox.Show("Multa removida com successo!");
                    CarregarMultas();
                }
            }
            else
            {
                MessageBox.Show("Nenhuma mula selecionada para remover.");
            }
>>>>>>> Stashed changes
        }
    }
}
