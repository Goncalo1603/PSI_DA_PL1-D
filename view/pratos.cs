using Projeto.controller;
using Projeto.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.view
{
    public partial class pratos : Form
    {
        private pratocontroller _pratocontroller;
        public pratos()
        {
            InitializeComponent();
            _pratocontroller = new pratocontroller();
        }

        private void pratos_Load(object sender, EventArgs e)
        {
            pratocontroller controller = new pratocontroller();
            List<prato> pratos = _pratocontroller.GetAllPratos();
            foreach (prato prato in pratos)
            {
                listBoxPratos.Items.Add($"{prato.descricao} - {prato.tipo} - {prato.ativo}");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxclientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonatualizar_Click(object sender, EventArgs e)
        {

            if (listBoxPratos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um prato para atualizar.");
                return;
            }

            int selectedIndex = listBoxPratos.SelectedIndex;
            string novaDescricao = textBoxDescricaoAtualizarPrato.Text;
            string novoTipo = textBoxTipoAtualizarPrato.Text;
            string novoAtivo = textBoxAtivoAtualizarPrato.Text;

            if (novoAtivo == "Sim" || novoAtivo == "Não")
            {

                listBoxPratos.Items[selectedIndex] = $"{novaDescricao} - {novoTipo} - {novoAtivo}";

                textBoxDescricaoAtualizarPrato.Text = string.Empty;
                textBoxTipoAtualizarPrato.Text = string.Empty;
                textBoxAtivoAtualizarPrato.Text = string.Empty;

                /*GUARDAR NA BD
                int pratoId = int.Parse(listBoxPratos.SelectedItem.ToString());
                string novaDescricao = textBoxDescricaoAtualizarPrato.Text;
                string novoTipo = textBoxTipoAtualizarPrato.Text;
                string novoAtivo = checkBoxAtivoAtualizarPrato.Checked;

                prato pratoAtualizado = new prato
                {
                    id = pratoId,
                    descricao = novaDescricao,
                    tipo = novoTipo,
                    ativo = novoAtivo
                };

                _pratocontroller.UpdatePrato(pratoAtualizado);
                MessageBox.Show("Prato atualizado com sucesso.");
                CarregarPratos();*/
            }
        }

        private void buttonadicionar_Click(object sender, EventArgs e)
        {
            string descricao = textBoxDescricaoNovoPrato.Text;
            string tipo = textBoxTipoNovoPrato.Text;
            string ativo = textBoxAtivoNovoPrato.Text;

            if (ativo == "Sim" || ativo == "Não")
            {
                prato novoPrato = new prato
                {
                    descricao = descricao,
                    tipo = tipo,
                    ativo = ativo
                };

                listBoxPratos.Items.Add(novoPrato.descricao);

                textBoxDescricaoNovoPrato.Text = string.Empty;
                textBoxTipoNovoPrato.Text = string.Empty;
                textBoxAtivoNovoPrato.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("O valor do campo 'ativo' não é válido");
            }
                
            

            

            /* GUARDAR NA BD
            string descricao = textBoxDescricaoNovoPrato.Text;
            string tipo = textBoxTipoNovoPrato.Text;
            bool ativo = checkBoxAtivoNovoPrato.Checked;

            prato novoPrato = new prato
            {
                descricao = descricao,
                tipo = tipo,
                ativo = ativo
            };

            _pratocontroller.AddPrato(novoPrato);

            listBoxPratos.Items.Add(novoPrato);

            textBoxDescricaoNovoPrato.Text = string.Empty;
            textBoxTipoNovoPrato.Text = string.Empty;
            textBoxAtivoNovoPrato.Text = string.Empty;
            CarregarPratos();*/

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNomeNovoPrato_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEliminarPratos_Click(object sender, EventArgs e)
        {

            if (listBoxPratos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um prato para eliminar.");
                return;
            }

            int selectedIndex = listBoxPratos.SelectedIndex;
            string descricao = listBoxPratos.SelectedItem.ToString();

            DialogResult resposta = MessageBox.Show("Tem certeza que deseja eliminar o prato '" + descricao + "'?", "Eliminar Prato", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                return;
            }

            listBoxPratos.Items.Remove(listBoxPratos.SelectedItem);

            /*GUARDAR NA BASE DE DADOS
            if (listBoxPratos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um prato para eliminar.");
                return;
            }

            string descricao = listBoxPratos.SelectedItem.ToString();

            try
            {
                _pratocontroller.EliminarPrato(descricao);
                MessageBox.Show("Prato eliminado com sucesso da base de dados.");

                CarregarPratos();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar prato da base de dados: " + ex.Message);

        }*/

        }

        private void buttonCarregarPratos_Click(object sender, EventArgs e)
        {
            pratocontroller controller = new pratocontroller();
            List<prato> pratos = _pratocontroller.GetAllPratos();
            foreach (prato prato in pratos)
            {
                listBoxPratos.Items.Add($"{prato.descricao} - {prato.tipo} - {prato.ativo}");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAtivoNovoPrato_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAtivoAtualizarPrato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
