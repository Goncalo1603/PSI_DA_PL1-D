using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.modelos
{
    public class fatura
    {
        public int id { get; set; }
        public float total {  get; set; }
        public DateTime data_hora_fatura { get; set; }

        public cliente cliente { get; set; }   // uma fatura pertence a 1 cliente
        public menu menu { get; set; } // uma fatura so tem 1 menu
        public List<itemfatura>itemfaturas { get; set; } // 1 fatura pode ter varios itens

        public fatura()
        {
            itemfaturas = new List<itemfatura>();
        }

    }
}
