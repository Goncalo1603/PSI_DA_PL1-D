using Projeto.modelos;
using System;
using System.Collections.Generic;
<<<<<<< Updated upstream
=======
using System.Data.Entity;
>>>>>>> Stashed changes
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Projeto.controller
{
    internal class maincontroller
    {
<<<<<<< Updated upstream
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
=======
        public void InserirFuncionario(funcionario funcionario)
        {
            using (var db = new ProjetoContext())
            {
                db.utilizadores.Add(funcionario);
                db.SaveChanges();
            }
        }

        public List<funcionario> ObterFuncionarios()
        {
            using (var db = new ProjetoContext())
            {
                return db.funcionarios.ToList();
            }
        }

        public void RemoverFuncionario(funcionario funcionario)
        {
            using (var db = new ProjetoContext())
            {
                db.Entry(funcionario).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }


        public void AdicionarUtilizador(utilizador utilizador)
        {
            using (var db = new ProjetoContext())
            {
                db.utilizadores.Add(utilizador);
                db.SaveChanges();
            }
        }

        public void RemoverUtilizador(utilizador utilizador)
        {
            using (var db = new ProjetoContext())
            {
                db.Entry(utilizador).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<utilizador> Obterclientes()
        {
            using (var db = new ProjetoContext())
            {
                return db.utilizadores.ToList();
            }
        }


        public void AdicionarPrato(prato prato)
        {
            using (var db = new ProjetoContext())
            {
                db.pratos.Add(prato);
                db.SaveChanges();
            }
        }

        public List<prato> ObterPratos()
        {
            using (var db = new ProjetoContext())
            {
                return db.pratos.ToList();
            }
        }

        public void RemoverPrato(prato prato)
        {
            using (var db = new ProjetoContext())
            {
                db.Entry(prato).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }



        public void AdicionarExtra(extra extra)
        {
            using (var db = new ProjetoContext())
            {
                db.extras.Add(extra);
                db.SaveChanges();
            }
        }

        public List<extra> ObterExtras()
        {
            using (var db = new ProjetoContext())
            {
                return db.extras.ToList();
            }
        }

        public void RemoverExtra(extra extra)
        {
            using (var db = new ProjetoContext())
            {
                db.Entry(extra).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }


        public List<menu> ObterMenus()
        {
            using (var context = new ProjetoContext())
            {
                return context.menus
                    .Include(m => m.pratos)
                    .Include(m => m.extras)
                    .ToList();
            }
        }
        public void InserirMenu(menu menu)
        {
            using (var db = new ProjetoContext())
            {
                db.menus.Add(menu);
                db.SaveChanges();
            }
        }
        public void RemoverMenu(menu menu)
        {
            using (var db = new ProjetoContext())
            {
                db.Entry(menu).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }


        public void InserirMulta(multa multa)
        {
            using (var db = new ProjetoContext())
            {
                db.multas.Add(multa);
                db.SaveChanges();
            }
        }

        public List<multa> ObterMultas()
        {
            using (var db = new ProjetoContext())
            {
                return db.multas.ToList();
            }
        }
        public void RemoverMulta(multa multa)
        {
            using (var db = new ProjetoContext())
            {
                db.Entry(multa).State = EntityState.Deleted;
                db.SaveChanges();
            }


>>>>>>> Stashed changes
        }
    }
}
