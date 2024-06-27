using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Projeto.modelos
{
    public  class ProjetoContext : DbContext
    {
        public DbSet<utilizador>utilizadores {  get; set; }
        public DbSet<funcionario> funcionarios { get; set; }
        public DbSet<cliente> clientes { get; set; }
        public DbSet<estudante> estudantes { get; set; }
        public DbSet<professor> professores { get; set;}
        public DbSet<multa>multas {  get; set; }
<<<<<<< Updated upstream
        public DbSet<Reserva>reservas {  get; set; }
=======
        public DbSet<reserva>reservas {  get; set; }
>>>>>>> Stashed changes
        public DbSet<prato> pratos {  get; set; }
        public DbSet<extra>extras { get; set; }
        public DbSet<menu>menus {  get; set; }
        public DbSet<fatura>faturas {  get; set; }
        public DbSet <itemfatura>itemfaturas { get; set; }

        public ProjetoContext() : base("name=ProjetoContext")
        {
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
        }

    }
}
