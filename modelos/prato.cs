using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.modelos
{
    public class prato
    {
        public int id { get; set; }
        public string descricao {  get; set; }
        public string tipo { get; set; }
        public string ativo { get; set; }
        public List<Reserva>reservas {  get; set; } // 1 prato pode estar em varias reservas
        public List<menu>menus { get; set; } // 1 prato pode ter varios menus
        public prato() 
        {
            reservas = new List<Reserva>();
            menus = new List<menu>();
        }


    }
}
