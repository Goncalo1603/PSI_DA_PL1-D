using Projeto.controller;
using Projeto.modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Projeto.view
{
    public partial class menus : Form
    {
        private menuscontroller _menusController;
        private maincontroller _mainController;

        // Campos para armazenar pratos e extras
        private List<prato> pratos;
        private List<extra> extras;

        public menus()
        {
            InitializeComponent();
            InicializarControladores();
            CarregarMenus();
        }

        private void InicializarControladores()
        {
            _mainController = new maincontroller();
            _menusController = new menuscontroller(_mainController);
        }

        private void CarregarMenus()
        {
            try
            {
                DateTime data_hora = monthCalendar1.SelectionRange.Start;

                pratos = _menusController.ObterPratosPorData(data_hora);
                extras = _menusController.ObterExtrasPorData(data_hora);
             
                // Obter o menu com base na data
                menu menu = _mainController.ObterMenus().FirstOrDefault(m => m.data_hora == data_hora);

                // Exibir os detalhes do menu na GroupBox
                if (menu != null)
                {
                    labelQtdDisp.Text = menu.qtd_disponvel.ToString();
                    labelPrecoAln.Text = menu.preco_estudante.ToString();
                    labelPrecoProf.Text = menu.preco_professor.ToString();
                }
                else 
                {
                    labelQtdDisp.Text = "0";
                    labelPrecoAln.Text = "0";
                    labelPrecoProf.Text = "0";
                }

                listBoxpratos.Items.Clear();
                listBoxextras.Items.Clear();

                if (pratos != null && pratos.Count > 0)
                {
                    foreach (var prato in pratos)
                    {
                        listBoxpratos.Items.Add(prato.descricao);
                    }
                }
                else
                {
                    MessageBox.Show("Não há pratos no menu.");
                }

                if (extras != null && extras.Count > 0)
                {
                    foreach (var extra in extras)
                    {
                        listBoxextras.Items.Add(extra.descricao);
                    }
                }
                else
                {
                    MessageBox.Show("Não há extras no menu.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar menus: {ex.Message}");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            CarregarMenus();
        }

        private void Alterarpratoseextras_Click(object sender, EventArgs e)
        {
            pratos = _menusController.GetAllPratos();
            extras = _menusController.GetAllExtras();

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            foreach (var prato in pratos)
            {
                listBox1.Items.Add(prato.descricao); // Add the description to the listBox
                listBox1.DisplayMember = "descricao"; // Ensure the display member is set
                listBox1.ValueMember = "id"; // Set the value member to the ID
            }

            foreach (var extra in extras)
            {
                listBox2.Items.Add(extra.descricao); // Add the description to the listBox
                listBox2.DisplayMember = "descricao"; // Ensure the display member is set
                listBox2.ValueMember = "id"; // Set the value member to the ID
            }

            groupBox1.Visible = true;
        }

        private void buttonsalvar_Click(object sender, EventArgs e)
        {
            DateTime data_hora = monthCalendar1.SelectionRange.Start;

            // Verifique se pratos e extras não são nulos antes de acessá-los
            if (pratos != null && extras != null)
            {
                menu menu = _mainController.ObterMenus().FirstOrDefault(m => m.data_hora == data_hora);

                if (menu == null)
                {
                
                    var pratoIds = listBox1.SelectedIndices.Cast<int>().Select(index => pratos[index].id).ToList();
                    var extraIds = listBox2.SelectedIndices.Cast<int>().Select(index => extras[index].id).ToList();
                    var quantidade = numericUpDownQtd.Value;
                    var precoAluno = numericUpDownPrecoAl.Value;
                    var precoProf = numericUpDownPrecoProf.Value;


                    _menusController.AdicionarMenu(pratoIds, data_hora, extraIds, (int)quantidade, (float)precoAluno, (float)precoProf);
                    MessageBox.Show("Menu adicionado com sucesso");
                    CarregarMenus();
                    groupBox1.Visible = false;
                
                }
                else
                {
                    MessageBox.Show("Já existe menu neste dia");
                }                
            }
            else
            {
                MessageBox.Show("Não foi possível salvar o menu. Os pratos ou extras não foram carregados corretamente.");
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            CarregarMenus();
        }

        private void buttonvoltar_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            this.Hide();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data_hora = monthCalendar1.SelectionRange.Start;
            menu menu = _mainController.ObterMenus().FirstOrDefault(m => m.data_hora == data_hora);

            _menusController.RemoverMenu(menu);
            MessageBox.Show("Menu removido com successo!");
            CarregarMenus();
        }
    }
}
