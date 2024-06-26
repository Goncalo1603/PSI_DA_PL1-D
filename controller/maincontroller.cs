using Projeto.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Projeto.controller
{
    internal class maincontroller
    {
        private ExtraController _extracontroller;
        private pratocontroller _pratocontroller;
        private ReservaController _reservacontroller;

        public maincontroller()
        {

            _extracontroller = new ExtraController();
            _pratocontroller = new pratocontroller();
            _reservacontroller = new ReservaController();
        }

        public void AddPrato(string descricao, string tipo, string ativo)
        {
            prato novoPrato = new prato
            {
                descricao = descricao,
                tipo = tipo,
                ativo = ativo
            };

            _pratocontroller.AddPrato(novoPrato);
        }

        public void UpdatePrato(int id, string descricao, string tipo, string ativo)
        {
            prato pratoAtualizado = new prato
            {
                id = id,
                descricao = descricao,
                tipo = tipo,
                ativo = ativo
            };

            _pratocontroller.UpdatePrato(pratoAtualizado);
        }

        public void PratoExtra(int id, string descricao, string tipo, string ativo)
        {
            _pratocontroller.DeletePrato(id);
        }

        public void AddExtra(string descricao, float preco, string ativo)
        {
            extra novoExtra = new extra
            {
                descricao = descricao,
                preco = preco,
                ativo = ativo
            };

            _extracontroller.AddExtra(novoExtra);
        }

        public void UpdateExtra(int id, string descricao, float preco, string ativo)
        {
            extra extraAtualizado = new extra
            {
                id = id,
                descricao = descricao,
                preco = preco,
                ativo = ativo
            };

            _extracontroller.UpdateExtra(extraAtualizado);
        }

        public void DeleteExtra(int id, string descricao, float preco, string ativo)
        {
            _extracontroller.DeleteExtra(id);
        }

        public List<prato> GetAllPratos()
        {
            return _pratocontroller.GetAllPratos();
        }

        public List<extra> GetAllExtras()
        {
            return _extracontroller.GetAllExtras();
        }

        public List<Reserva> GetAllReservas()
        {
            return _reservacontroller.GetAllReservas();
        }
    }
}
