<<<<<<< Updated upstream
﻿using System;
=======
﻿using Projeto.controller;
using Projeto.modelos;
using Projeto.view;
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

namespace Projeto
{
    public partial class Form1 : System.Windows.Forms.Form
    {
<<<<<<< Updated upstream
        public Form1()
        {
            InitializeComponent();
=======
        private menuscontroller _menusController;
        private maincontroller _mainController;

        // Campos para armazenar pratos e extras
        private List<prato> pratos;
        private List<extra> extras;
        public Form1()
        {
            InitializeComponent();
            InicializarControlador();
        }

        private void InicializarControlador()
        {
            
                _mainController = new maincontroller();
                _menusController = new menuscontroller(_mainController);
 
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======

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
            pratos func = new pratos();
            func.Show();
            this.Hide();
        }

        private void buttonextras_Click(object sender, EventArgs e)
        {
            extras func = new extras();
            func.Show();
            this.Hide();
        }

        private void buttonmenu_Click(object sender, EventArgs e)
        {
            menus func = new menus();
            func.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void buttonmultas_Click(object sender, EventArgs e)
        {
            multas func = new multas();
            func.Show();
            this.Hide();
        }

        private void CarregarMenuPorData()
        {
            try
            {
                string newLine = Environment.NewLine;

                DateTime data_hora = monthCalendar1.SelectionRange.Start;

                pratos = _menusController.ObterPratosPorData(data_hora);
                extras = _menusController.ObterExtrasPorData(data_hora);

                // Obter o menu com base na data
                menu menu = _mainController.ObterMenus().FirstOrDefault(m => m.data_hora == data_hora);

                // Exibir os detalhes do menu na GroupBox
                if (menu != null)
                {
                    textBox2.Text = $"Nome do prato: {menu.pratos[0].descricao}\r\n";
                    textBox2.Text += $"Nome do extra: {menu.extras[0].descricao}\r\n";
                    textBox2.Text += $"Preço para estudante: {menu.preco_estudante}€\r\n";
                    textBox2.Text += $"Preço para professor: {menu.preco_professor}€\r\n";
                    textBox2.Text += $"Quantidade disponível: {menu.qtd_disponvel}\r\n";

                }
                else 
                {
                    textBox2.Text = "Não existe menus para o dia selecionado";
                }
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar menus: {ex.Message}");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            CarregarMenuPorData();
        }
>>>>>>> Stashed changes
    }
}
