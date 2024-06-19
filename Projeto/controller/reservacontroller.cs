using Projeto.modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.controller
{
    public class ReservaController
    {

        private List<Reserva> _reservas;

        public void reservacontroller()
        {
            _reservas = new List<Reserva>();
        }

        public void AddReserva(Reserva reserva)
        {
            _reservas.Add(reserva);
        }

        public List<Reserva> GetAllReservas()
        {
            return _reservas;
        }

        /*GUARDAR NA BASE DE DADOS

        public class reservacontroller
        {
            private readonly DbContext _context;

            public reservacontroller(DbContext context)
            {
                _context = context;
            }

            public List<reserva> GetAllReservas()
            {
                return _context.Reservas.ToList();
            }

            public void AddReserva(reserva reserva)
            {
                _context.Reservas.Add(reserva);
                _context.SaveChanges();
            }

            public void MarkReservaAsEfetuada(int reservaId)
            {
                var reserva = _context.Reservas.Find(reservaId);
                if (reserva!= null)
                {
                    reserva.Efetuada = true;
                    _context.SaveChanges();
                }
            }*/
    }
}