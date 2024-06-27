using Projeto.modelos;
using System;
using System.Collections.Generic;
<<<<<<< Updated upstream
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> Stashed changes

namespace Projeto.controller
{
    internal class pratocontroller
    {
<<<<<<< Updated upstream
        public List<prato> GetAllPratos()
        {
            using (var context = new ProjetoContext())
            {
                return context.pratos.ToList();
            }
        }

        public void AddPrato(prato prato)
        {
                using (var context = new ProjetoContext())
                {
                        
                        if(prato.ativo=="Sim" || prato.ativo=="Não")
                        {
                            context.pratos.Add(prato);
                            context.SaveChanges();
                        }
                        
                }
        }

        public void UpdatePrato(prato prato)
        {
                using (var context = new ProjetoContext())
                {
                        context.Entry(prato).State = EntityState.Modified;
                        context.SaveChanges();
                }
        }

        public void DeletePrato(int id)
        {
                using (var context = new ProjetoContext())
                {
                        prato prato = context.pratos.FirstOrDefault(p => p.id == id);
                        if (prato != null)
                        {
                                context.pratos.Remove(prato);
                                context.SaveChanges();
                        }
                }
        }

        /*private void CarregarPratos()
        {
            List<prato> pratos = _pratocontroller.GetPratos();

            listBoxPratos.Items.Clear();

            foreach (prato prato in pratos)
            {
                listBoxPratos.Items.Add($"{prato.descricao} - {prato.tipo} - {prato.ativo}");
            }
        }*/
=======
        private readonly maincontroller _principalController;

        public pratocontroller(maincontroller principalController)
        {
            _principalController = principalController ?? throw new ArgumentNullException(nameof(principalController));
        }


        public void AdicionarPrato(string descricao, string tipo, string ativo)
        {
            var prato = new prato
            {
                descricao = descricao,
                tipo = tipo,
                ativo = ativo
            };

            _principalController.AdicionarPrato(prato);
        }
>>>>>>> Stashed changes
    }
}
