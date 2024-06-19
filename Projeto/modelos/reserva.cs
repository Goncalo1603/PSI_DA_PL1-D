using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.modelos
{
    public class Reserva
    {
        public int id { get; set; }
        public cliente cliente { get; set; } // uma reserva pertence a 1 cliente
        public multa multa { get; set; } // uma reserva só pode ter 1 multa
        public prato prato { get; set; } // uma reserva so pode ter 1 prato
        public extra extra { get; set; } // uma reserva pode ter 1 extra
        public menu menu { get; set; } // uma reserva so pode ter 1 menu

    }
}
