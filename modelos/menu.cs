using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.modelos
{
    public class menu
    {
        public int id {  get; set; }    
        public DateTime data_hora {  get; set; }
        public int qtd_disponvel {  get; set; }
        public float preco_estudante {  get; set; }
        public float preco_professor { get; set; }
        public List<reserva> reservas {  get; set; } // 1 menu pode ter varias reservas
        public List<prato>pratos { get; set; } // 1 menu pode ter varios pratos
        public List<extra>extras {  get; set; } //1 menu pode ter varios extras
        public List<fatura>faturas { get; set; } //1 menu pode ter varias faturas


        public menu()
        {
            reservas = new List<reserva>();
            pratos = new List<prato>();
            extras = new List<extra>();
            faturas = new List<fatura>();
        }
    }
}
