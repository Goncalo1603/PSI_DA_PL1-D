using Projeto.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.controller
{
    internal class funcionariocontroller
    {
<<<<<<< Updated upstream

       
=======
        private readonly maincontroller _principalController;

        public funcionariocontroller(maincontroller principalController)
        {
            _principalController = principalController ?? throw new ArgumentNullException(nameof(principalController));
        }

        public void AdicionarFuncionario(string nome, string nif, string username)
        {
            var funcionario = new funcionario
            {
                nome = nome,
                nif = nif,
                username = username
            };

            _principalController.InserirFuncionario(funcionario);
        }

        public void RemoverFuncionario(funcionario funcionario)
        {
            _principalController.RemoverFuncionario(funcionario);
        }

>>>>>>> Stashed changes
    }
}
