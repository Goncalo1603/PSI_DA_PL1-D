using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.modelos
{
    public class multa
    {
        public int id { get; set; }
        public float valor {  get; set; }
        public float num_horas { get; set; }
        public List<Reserva>reservas { get; set; } //uma multa pode ter varias reservas

        public multa()
        {
            reservas = new List<Reserva>();
        }
    }
}
