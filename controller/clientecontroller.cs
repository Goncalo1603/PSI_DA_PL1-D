using Projeto.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.controller
{
    internal class clientecontroller
    {

        public class ClienteController
        {
            private readonly maincontroller _mainController;


            public ClienteController(maincontroller mainController)
            {
                this._mainController = mainController;
            }



            public void AdicionaEstudante(string nome, string nif,float saldo, int numEstudante)
            {
                var estudante = new estudante
                {
                    nome = nome,
                    nif = nif,
                    saldo = saldo,
                    numero_estudante = numEstudante
                };

                _mainController.AdicionarUtilizador(estudante);
            }

            public void AdicionarProfessor(string nome, string nif, float saldo, string email)
            {
                var professor = new professor
                {
                    nome = nome,
                    nif = nif,
                    saldo = saldo,
                    email = email
                };

                _mainController.AdicionarUtilizador(professor);
            }

            public void RemoverCliente(utilizador utilizador)
            {
                _mainController.RemoverUtilizador(utilizador);
            }
        }

    }

}


