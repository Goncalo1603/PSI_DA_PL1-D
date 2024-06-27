using Projeto.controller;
using Projeto.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
<<<<<<< Updated upstream
=======
using System.IO;
>>>>>>> Stashed changes
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< Updated upstream
=======
using System.Xml.Linq;
using static Projeto.controller.clientecontroller;
using iTextSharp.text;
using iTextSharp.text.pdf;
>>>>>>> Stashed changes

namespace Projeto
{
    public partial class reservas : Form
    {
<<<<<<< Updated upstream
        private ReservaController _controller;

        public reservas()
        {
            InitializeComponent();
            _controller = new ReservaController();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            List<Reserva> reservas = _controller.GetAllReservas();
            listBoxReservas.Items.Clear();
            foreach (Reserva reserva in reservas)
            {
                listBoxReservas.Items.Add(reserva.id + " - " + reserva.cliente.nome);
            }
        }

        private void buttonAddReserva_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            _controller.AddReserva(reserva);
            listBoxReservas.Items.Add(reserva.id + " - " + reserva.cliente.nome);
        }

        private void tabPageMarcarReserva_Click(object sender, EventArgs e)
        {

        }

        private void buttonMarcarReservaComoEfetuada_Click(object sender, EventArgs e)
        {

        }
    }
}

/* GUARDAR NA BASE DE DADOS
namespace Projeto
{
    public partial class reservas : Form
    {
        private ReservaController _controller;

        public reservas()
        {
            InitializeComponent();
            _controller = new ReservaController(new DbContext()); // SUBSTITUIR COM DBCONTEXT CLASS
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            List<Reserva> reservas = _controller.GetAllReservas();
            listBoxReservas.Items.Clear();
            foreach (Reserva reserva in reservas)
            {
                listBoxReservas.Items.Add(reserva.id + " - " + reserva.cliente.nome);
            }
        }

        private void buttonMarcarReservaComoEfetuada_Click(object sender, EventArgs e)
        {
            int reservaId = int.Parse(listBoxReservas.SelectedItem.ToString().Split('-')[0].Trim());
            _controller.MarkReservaAsEfetuada(reservaId);
        }
    }
}*/
=======
        private ClienteController _clienteController;
        private maincontroller _mainController;
        private pratocontroller _pratocontroller;
        private extracontroller _extracontroller;
        public reservas()
        {
            InitializeComponent();
            InicializarControladores();
            CarregarClientes();
            CarregarExtras();
            CarregarPratos();
        }
        private void InicializarControladores()
        {
            _mainController = new maincontroller();
            _clienteController = new ClienteController(_mainController);
            _pratocontroller = new pratocontroller(_mainController);
            _extracontroller = new extracontroller(_mainController);
        }
        private void label8_Click(object sender, EventArgs e)
        {

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

        private void CarregarExtras()
        {
            try
            {
                if (_mainController != null)
                {
                    List<extra> extras = _mainController.ObterExtras();

                    listBoxextras.Items.Clear();

                    foreach (var extra in extras)
                    {
                        listBoxextras.Items.Add($"{extra.descricao}");
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao carregar Extras: PrincipalController é null.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar Extras: {ex.Message}");
            }
        }

        private void CarregarPratos()
        {
            try
            {
                if (_mainController != null)
                {
                    List<prato> pratos = _mainController.ObterPratos();

                    listBoxpratos.Items.Clear();

                    foreach (var prato in pratos)
                    {
                        listBoxpratos.Items.Add($"{prato.descricao}");
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao carregar Pratos: PrincipalController é null.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar Pratos: {ex.Message}");
            }
        }

        private void buttongerarfatura_Click(object sender, EventArgs e)
        {
            if (listBoxextras.SelectedItem != null && listBoxclientes.SelectedItem != null && listBoxpratos.SelectedItem != null)
            {
                string extraselecionado = listBoxextras.SelectedItem.ToString();
                string pratoselecionado = listBoxpratos.SelectedItem.ToString();
                string clienteselecionado = listBoxclientes.SelectedItem.ToString();
                string[] detalhesextra = extraselecionado.Split('-');

                string descricaoExtra = detalhesextra[0].Trim();
               

       

                GerarPDF(clienteselecionado, pratoselecionado, descricaoExtra);
            }
            else
            {
                MessageBox.Show("Selecione o Cliente, Prato e Extra.");
            }

        }


        private void GerarPDF(string nomeCliente, string nomePrato, string descricaoExtra)
        {
            Document doc = new Document();
            try
            {
                PdfWriter.GetInstance(doc, new FileStream("Pedido.pdf", FileMode.Create));
                doc.Open();

                doc.Add(new Paragraph("Detalhes do Pedido"));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph($"Nome do Cliente: {nomeCliente}"));
                doc.Add(new Paragraph($"Nome do Prato: {nomePrato}"));
                doc.Add(new Paragraph($"Descrição do Extra: {descricaoExtra}"));

                MessageBox.Show("PDF gerado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar PDF: {ex.Message}");
            }
            finally
            {
                doc.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 func = new Form1();
            func.Show();
            this.Hide();
        }
    }
}
>>>>>>> Stashed changes
