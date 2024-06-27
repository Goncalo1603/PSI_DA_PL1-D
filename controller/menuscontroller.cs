using Projeto.modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
            using (var context = new ProjetoContext())
            {
                var menuForDate = context.menus
                    .Include("pratos")
                    .Include("extras")
                    .SingleOrDefault(m => DbFunctions.TruncateTime(m.data_hora) == DbFunctions.TruncateTime(date));

                return menuForDate?.pratos ?? new List<prato>();
            }
        }

        public List<extra> ObterExtrasPorData(DateTime date)
        {
            using (var context = new ProjetoContext())
            {
                var menuForDate = context.menus
                    .Include("extras")
                    .Include("pratos")
                    .SingleOrDefault(m => DbFunctions.TruncateTime(m.data_hora) == DbFunctions.TruncateTime(date));

                return menuForDate?.extras ?? new List<extra>();
            }
        }
        public List<menu> ObterMenusPorData(DateTime data)
        {
            using (var dbContext = new ProjetoContext())
            {
                return dbContext.menus
                    .Where(m => m.data_hora == data)
                    .ToList();
            }
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

        public void AdicionarMenu(List<int> pratoIds, DateTime data, List<int> extraIds, int quantidade, float precoAluno, float precoProf)
        {
            using (var context = new ProjetoContext())
            {
                var pratos = context.pratos.Where(p => pratoIds.Contains(p.id)).ToList();
                var extras = context.extras.Where(e => extraIds.Contains(e.id)).ToList();

                var menu = new menu
                {
                    pratos = pratos,
                    data_hora = data,
                    extras = extras,
                    qtd_disponvel = quantidade,
                    preco_estudante = precoAluno,
                    preco_professor = precoProf,
                };

                context.menus.Add(menu);
                context.SaveChanges();
            }
        }
        public void RemoverMenu(menu menu)
        {
            _mainController.RemoverMenu(menu);
        }
    }
}
