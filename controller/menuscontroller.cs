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
        
    }
}
