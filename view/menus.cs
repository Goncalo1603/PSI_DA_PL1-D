using Projeto.controller;
using Projeto.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.view
{
    
    public partial class menus : Form
    {
        private menuscontroller _menusController;
        private maincontroller _mainController;
        public menus()
        {
            InitializeComponent();
            InicializarControladores();
            //CarregarMenus();
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
                if (_mainController != null)
                {
                    DateTime data_hora = monthCalendar1.SelectionRange.Start;

                    List<menu> menus = _mainController.ObterMenus();
                    menu menu = _mainController.ObterMenus().FirstOrDefault(m => m.data_hora == data_hora);
                    List<prato> pratos = _menusController.ObterPratosPorData(data_hora);

                    listBoxpratos.Items.Clear();
                     

                        if (menu != null)
                        {
                            if (menu.pratos.Count > 0)
                            {
                                foreach (prato prato in menu.pratos)
                                {
                                    if (!string.IsNullOrEmpty(prato.descricao))
                                    {
                                        listBoxpratos.Items.Add(prato.descricao);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Descricao is null or empty for one or more pratos.");
                                    }
                                }
                            }
                            else
                            {
                            MessageBox.Show("Não há pratos");
                            }
                        }
                        else
                        {
                        MessageBox.Show("Não há menu");
                        }
                }
                else
                {
                    MessageBox.Show("Main é null");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar menus: {ex.Message}");
            }
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void Alterarpratoseextras_Click(object sender, EventArgs e)
        {
            List<prato> pratos = _menusController.GetAllPratos();
            List<extra> extras = _menusController.GetAllExtras();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (prato prato in pratos)
            {
                listBox1.Items.Add(prato.descricao);
            }
            foreach (extra extra in extras)
            {
                listBox2.Items.Add(extra.descricao);
            }

            groupBox1.Visible = true;
        }

        private void buttonsalvar_Click(object sender, EventArgs e)
        {
            DateTime data_hora = monthCalendar1.SelectionRange.Start;

            List<prato> prato = listBox1.SelectedItem as List<prato>;
            List<extra> extra = listBox2.SelectedItem as List<extra>;

            _menusController.AdicionarMenu(prato, data_hora, extra);
            MessageBox.Show("Menu adiconado com sucesso");
            CarregarMenus();
            groupBox1.Visible = false;
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
    }
}
