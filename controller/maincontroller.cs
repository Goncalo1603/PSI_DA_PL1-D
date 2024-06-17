using Projeto.modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Projeto.controller
{
    internal class maincontroller
    {
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
    }
}
