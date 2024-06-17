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
using static Projeto.controller.clientecontroller;

namespace Projeto
{
    public partial class cliente : Form
    {
        private ClienteController _clienteController;
        private maincontroller _mainController;

        public cliente()
        {
            InitializeComponent();
            InicializarControladores();
            CarregarClientes();

        }

        private void InicializarControladores()
        {
            _mainController = new maincontroller();
            _clienteController = new ClienteController(_mainController);
        }

        private void CarregarClientes()
        {
            try
            {
                if (_mainController != null)
                {
                    List<utilizador> clientes = _mainController.Obterclientes();

                    listBoxclientes.Items.Clear();

                    foreach (var cliente in clientes)
                    {
                        listBoxclientes.Items.Add($"{cliente.nome}");
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao carregar Clientes: PrincipalController é null.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar Clientes: {ex.Message}");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonvoltar_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            this.Close();
        }

        private void buttoncriarcliente_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            string nome = textBoxinserirNome.Text;
            string nif = textBoxinserirNif.Text;
            float saldo = float.Parse(textBox1.Text);
            

            if(radioButtonaluno.Checked)
            {
                int numestudante = int.Parse(texboxinserirnumestudante.Text);
                _clienteController.AdicionaEstudante(nome, nif, saldo, numestudante);
                MessageBox.Show("Cliente Adicionado com sucesso");
            }else if(radioButton1.Checked)
            {
                string email = textBoxinseriremail.Text;
                _clienteController.AdicionarProfessor(nome, nif, saldo, email);
                MessageBox.Show("Cliente Adicionado com sucesso");
            }
            else
            {
                MessageBox.Show("Selecione o tipo de utilizador.");
                return;
            }

            CarregarClientes();

        }

        private void buttonapagarCliente_Click(object sender, EventArgs e)
        {
            if (listBoxclientes.SelectedItem != null)
            {
                string selectedCliente = listBoxclientes.SelectedItem.ToString();
                string[] clienteDetails = selectedCliente.Split('-');

                // Recuperar o nome do cliente
                string nome = clienteDetails[0].Trim();

                // Obter o cliente com base no nome
                utilizador cliente = _mainController.Obterclientes().FirstOrDefault(c => c.nome == nome);

                // Remover o cliente da base de dados
                if (cliente != null)
                {
                    _mainController.RemoverUtilizador(cliente);
                    MessageBox.Show("Cliente removido com sucesso!");
                    CarregarClientes(); // Atualiza a lista de clientes na ListBox
                }
            }
            else
            {
                MessageBox.Show("Nenhum cliente selecionado para remover.");
            }
        }

        private void radioButtonaluno_CheckedChanged(object sender, EventArgs e)
        {
            labelinserirnumemail.Show();
            texboxinserirnumestudante.Show();
            label1.Hide();
            textBoxinseriremail.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Show();
            textBoxinseriremail.Show();
            labelinserirnumemail.Hide();
            texboxinserirnumestudante.Hide();
        }

        private void labeltipocliente_Click(object sender, EventArgs e)
        {

        }

        private void listBoxclientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxclientes.SelectedItem != null)
            {
                string selectedcliente = listBoxclientes.SelectedItem.ToString();
                string[] clienteDetails = selectedcliente.Split('-');

                string nome = clienteDetails[0].Trim();

                utilizador utilizador = _mainController.Obterclientes().FirstOrDefault(c => c.nome == nome);

                if (utilizador != null)
                {
                    groupBox1.Visible = true;
                    labelnomeCliente.Text = $"Nome: {utilizador.nome}";
                    labelnifCliente.Text = $"NIF: {utilizador.nif}";
                   

                    // Mostrar dados específicos do cliente
                    if (utilizador is estudante)
                    {
                        estudante estudante = (estudante)utilizador;
                        labelsaldo.Text = $"Saldo: {estudante.saldo}";
                        labelnumestudante.Text = $"Número de Estudante: {estudante.numero_estudante}";
                        labeltipocliente.Text = "Estudante";
                        labelemail.Hide();
                        labelsaldo.Show();
                        labelnumestudante.Show();
                    }
                    else if (utilizador is professor)
                    {
                        professor professor = (professor)utilizador;
                        labelsaldo.Text = $"Saldo: {professor.saldo}";
                        labelemail.Text = $"Email: {professor.email}";
                        labeltipocliente.Text = "Professor";
                        labelnumestudante.Hide();
                        labelsaldo.Show();
                        labelemail.Show();
                    }
                    else if (utilizador is funcionario)
                    {
                        labeltipocliente.Text = "Funcionario";
                        labelsaldo.Hide();
                        labelnumestudante.Hide();
                        labelemail.Hide();
                    }

                    groupBox2.Visible = false;
                }
            }
        }
    }
}
