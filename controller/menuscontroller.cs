using Projeto.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.controller
{
    internal class menuscontroller
    {
        private readonly maincontroller _mainController;

        public menuscontroller(maincontroller mainController)
        {
            this._mainController = mainController;
        }

        public List<prato> ObterPratosPorData(DateTime date)
        {
            var menus = _mainController.ObterMenus();
            var menuForDate = menus.SingleOrDefault(m => m.data_hora.Date == date.Date);
            return menuForDate?.pratos;
        }

        public List<prato> GetAllPratos()
        {
            using (var context = new ProjetoContext())
            {
                return context.pratos.ToList();
            }
        }
        public List<extra> GetAllExtras()
        {
            using (var context = new ProjetoContext())
            {
                return context.extras.ToList();
            }
        }
        public void AdicionarMenu(List<prato> prato, DateTime data, List<extra> extra)
        {
            var menu = new menu
            {
                pratos = prato,
                data_hora = data,
                extras = extra,
            };

            _mainController.InserirMenu(menu);
        }

    }
}
