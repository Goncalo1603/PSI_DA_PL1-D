using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.modelos
{
    public class cliente : utilizador
    {
        public int id {  get; set; }
        public float saldo {  get; set; }
        public List<fatura> faturas { get; set; } // um cliente pode ter varias faturas

        public List<reserva>reservas { get; set; } // um cliente pode ter varias reservas

        public cliente()
        {
            faturas = new List<fatura>();
        }
    }
}
