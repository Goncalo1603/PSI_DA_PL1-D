using Projeto.modelos;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace Projeto.controller
{
    internal class extracontroller
    {
        public List<extra> GetAllExtras()
        {
            using (var context = new ProjetoContext())
            {
                return context.extras.ToList();
            }
        }

        public void AddExtra(extra extra)
        {
            using (var context = new ProjetoContext())
            {
                context.extras.Add(extra);
                context.SaveChanges();
            }
        }

        public void UpdateExtra(extra extra)
        {
            using (var context = new ProjetoContext())
            {
                context.Entry(extra).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteExtra(int id)
        {
            using (var context = new ProjetoContext())
            {
                extra extra = context.extras.FirstOrDefault(e => e.id == id);
                if (extra != null)
                {
                    context.extras.Remove(extra);
                    context.SaveChanges();
                }
            }
         }
    }
}