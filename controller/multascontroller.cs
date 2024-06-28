using Projeto.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.controller
{
    internal class multascontroller
    {
        private readonly maincontroller _mainController;

        public multascontroller(maincontroller mainController)
        {
            this._mainController = mainController;
        }

        public void AdicionarMulta(float valor, float num_horas)
        {
            var multa = new multa
            {
                valor = valor,
                num_horas = num_horas,
            };

            _mainController.InserirMulta(multa);
        }
        public void RemoverMulta(multa multa)
        {
            _mainController.RemoverMulta(multa);
        }

    }

}
