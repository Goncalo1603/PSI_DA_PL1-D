using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.modelos
{
    public class extra
    {
        public int id { get; set; }
        public string descricao {  get; set; }
        public float preco {  get; set; }
        public string ativo { get; set; }
        public List<reserva> reservas { get; set; } //um extra pode estar em varias reservas
        public List<menu>menus { get; set; } // 1 extra pode estar em  varios menus

        public extra()
        {
            reservas = new List<reserva>();
            menus = new List<menu>();
        }

    }
}
