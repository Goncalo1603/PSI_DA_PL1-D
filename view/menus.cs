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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void Alterarpratoseextras_Click(object sender, EventArgs e)
        {

        }

        private void buttonsalvar_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            

            DateTime data_hora = monthCalendar1.SelectionRange.Start;

            menu menu = _mainController.ObterMenus().FirstOrDefault(m => m.data_hora == data_hora);
            

            if (menu != null) 
            {
                _mainController.PopulatePratosCollection(menu);
                if (menu.pratos != null && menu.pratos.Count > 0)
                {
                    //listBoxpratos.Items.Clear();
                    groupBoxmenudodia.Visible = true;
                    listBoxpratos.DataSource = menu.pratos;
                    listBoxpratos.DisplayMember = "descricao";
                    /*
                     foreach (var prato in menu.pratos)
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
                    */
                }
                else
                {
                    listBox1.Items.Clear();
                    MessageBox.Show("No pratos found for the selected menu.");
                }



                /*
                groupBoxmenudodia.Visible = true;
               
                listBoxpratos.Items.Clear();
                foreach (var prato in menu.pratos) 
                {
                    listBoxpratos.Items.Add(prato.descricao);
                }
                
                listBoxextras.Items.Clear();
                listBoxextras.Items.Add(menu.extras);
                
                
                
                listBox1.DataSource = pratos;
                listBox1.DisplayMember = "descricao";
                */
            }
            else
            {
                MessageBox.Show("Não há menu neste dia");
            }
        }
    }
}
