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
<<<<<<< Updated upstream
        public funcionarios()
        {
            InitializeComponent();
        

        }

=======
        private  funcionariocontroller _funcionarioController;
        private  maincontroller _principalController;
        public funcionarios()
        {
            InitializeComponent();
            InicializarControladores();
            CarregarFuncionarios();

        }

        private void InicializarControladores()
        {
            _principalController = new maincontroller();
            _funcionarioController = new funcionariocontroller(_principalController);
        }

>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            var funcionario = new funcionario
            {
                nome = textBoxinserirNome.Text,
                nif = textBoxinserirNif.Text,
                username = textBoxusername.Text,
            };
=======
            string nome = textBoxinserirNome.Text;
            string nif = textBoxinserirNif.Text;
            string username = textBoxusername.Text;

            _funcionarioController.AdicionarFuncionario(nome, nif, username);
            MessageBox.Show("Funcionário adicionado com sucesso!");
            CarregarFuncionarios();
        }


        private void CarregarFuncionarios()
        {
            try
            {
                if (_principalController != null)
                {
                    List<funcionario> funcionarios = _principalController.ObterFuncionarios();

                    listBoxfuncionarios.Items.Clear();

                    foreach (var funcionario in funcionarios)
                    {
                        listBoxfuncionarios.Items.Add($"{funcionario.nome}");
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao carregar funcionários: PrincipalController é null.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar funcionários: {ex.Message}");
            }
        }

        private void listBoxfuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxfuncionarios.SelectedItem != null)
            {
                string selectedFuncionario = listBoxfuncionarios.SelectedItem.ToString();
                string[] funcionarioDetails = selectedFuncionario.Split('-');

                // Recuperar o nome do funcionário
                string nome = funcionarioDetails[0].Trim();

                // Obter o funcionário com base no nome
                funcionario funcionario = _principalController.ObterFuncionarios().FirstOrDefault(f => f.nome == nome);

                // Exibir os detalhes do funcionário na GroupBox
                if (funcionario != null)
                {
                    groupBox1.Visible = true;
                    labelnomeCliente.Text = $"Nome: {funcionario.nome}";
                    labelnifCliente.Text = $"NIF: {funcionario.nif}";
                    labelusername.Text = $"Username: {funcionario.username}";
                    groupBox2.Visible = false;
                }
            }
        }

        private void buttonapagarCliente_Click(object sender, EventArgs e)
        {
            if (listBoxfuncionarios.SelectedItem != null)
            {
                string selectedFuncionario = listBoxfuncionarios.SelectedItem.ToString();
                string[] funcionarioDetails = selectedFuncionario.Split('-');

                // Recuperar o nome do funcionário
                string nome = funcionarioDetails[0].Trim();

                // Obter o funcionário com base no nome
                funcionario funcionario = _principalController.ObterFuncionarios().FirstOrDefault(f => f.nome == nome);

                // Remover o funcionário da base de dados
                if (funcionario != null)
                {
                    _principalController.RemoverFuncionario(funcionario);
                    MessageBox.Show("Funcionário removido com sucesso!");
                    CarregarFuncionarios(); // Atualiza a lista de funcionários na ListBox
                }
            }
            else
            {
                MessageBox.Show("Nenhum funcionário selecionado para remover.");
            }
>>>>>>> Stashed changes
        }

      
    }
}
