using Projeto.controller;
using Projeto.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.view
{
    public partial class extras : Form
    {

        private ExtraController _extracontroller;
        public extras()
        {
            InitializeComponent();
            _extracontroller = new ExtraController();
        }

        private void extras_Load(object sender, EventArgs e)
        {
            ExtraController controller = new ExtraController();
            List<extra> extras = _extracontroller.GetAllExtras();
            foreach (extra extra in extras)
            {
                listBoxExtras.Items.Add($"{extra.descricao} - {extra.preco} - {extra.ativo}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCarregarPratos_Click(object sender, EventArgs e)
        {
            ExtraController controller = new ExtraController();
            List<extra> extras = _extracontroller.GetAllExtras();
            foreach (extra extra in extras)
            {
                listBoxExtras.Items.Add($"{extra.descricao} - {extra.preco} - {extra.ativo}");
            }
        }

        private void buttonAdicionarNovoExtra_Click(object sender, EventArgs e)
        {
            string descricao = textBoxDescricaoNovoExtra.Text;
            float preco = float.Parse(textBoxPrecoNovoExtra.Text);
            string ativo = textBoxAtivoNovoExtra.Text;

            if (ativo == "Sim" || ativo == "Não")
            {

                extra novoExtra = new extra()
                {
                    descricao = descricao,
                    preco = preco,
                    ativo = ativo
                };

                listBoxExtras.Items.Add(novoExtra);

                textBoxDescricaoNovoExtra.Text = string.Empty;
                textBoxAtivoNovoExtra.Text = string.Empty;

                /* GUARDAR NA BASE DE DADOS
                extracontroller controller = new extracontroller();
                controller.AddExtra(novoExtra);*/
            }
        }

        private void listBoxExtras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEliminarExtras_Click(object sender, EventArgs e)
        {
            if (listBoxExtras.SelectedItem == null)
            {
                MessageBox.Show("Selecione um extra para eliminar.");
                return;
            }

            int selectedIndex = listBoxExtras.SelectedIndex;
            string descricao = listBoxExtras.SelectedItem.ToString();

            DialogResult resposta = MessageBox.Show("Tem certeza que deseja eliminar o extra '" + descricao + "'?", "Eliminar Extra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                return;
            }

            listBoxExtras.Items.Remove(listBoxExtras.SelectedItem);

            /*GUARDAR NA BASE DE DADOS
            if (listBoxExtras.SelectedItem == null)
            {
                MessageBox.Show("Selecione um extra para eliminar.");
                return;
            }

            string descricao = listBoxExtras.SelectedItem.ToString();

            try
            {
                _extracontroller.EliminarExtra(descricao);
                MessageBox.Show("Extra eliminado com sucesso da base de dados.");

                CarregarExtras();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar prato da base de dados: " + ex.Message);

        }*/
        }

        private void textBoxDescricaoNovoExtra_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrecoNovoExtras_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAtualizarExtra_Click(object sender, EventArgs e)
        {
            if (listBoxExtras.SelectedItem == null)
            {
                MessageBox.Show("Selecione um extra para atualizar.");
                return;
            }

            int selectedIndex = listBoxExtras.SelectedIndex;
            string novaDescricao = textBoxDescricaoAtualizarExtra.Text;
            float novoPreco = float.Parse(textBoxPrecoAtualizarExtra.Text);
            string novoAtivo = textBoxAtivoAtualizarExtra.Text;

            if (novoAtivo == "Sim" || novoAtivo == "Não")
            {

                listBoxExtras.Items[selectedIndex] = $"{novaDescricao} - {novoPreco}";

                textBoxDescricaoAtualizarExtra.Text = string.Empty;
                textBoxAtivoAtualizarExtra.Text = string.Empty;

                /* GUARDAR NA BASE DE DADOS
                int selectedIndex = listBoxExtras.SelectedIndex;
                string descricao = textBoxDescricaoAtualizarExtra.Text;
                float preco = float.Parse(textBoxPrecoAtualizarExtra.Text);
                string ativo = textBoxAtivoAtualizarExtra.Text;

                extra extraAtualizado = new extra
                {
                    id = extraId,
                    descricao = novaDescricao,
                    preco = novoPreco,
                    ativo = novoAtivo
                };

                _extracontroller.UpdateExtra(extraAtualizado);
                MessageBox.Show("Extra atualizado com sucesso.");
                CarregarExtras();*/

            }
        }

        private void textBoxAtivoNovoExtra_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAtivoAtualizarExtra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
