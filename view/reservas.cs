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

namespace Projeto
{
    public partial class reservas : Form
    {
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