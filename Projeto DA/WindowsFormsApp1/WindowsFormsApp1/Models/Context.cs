using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Context:DbContext

    {
        // NOMES DAS DB        ||
        //                     VV
        public DbSet<Artigos> Artigos {  get; set; }

        public DbSet<Compras> Compras {  get; set; }

        public DbSet<Item> Items {  get; set; }

        public DbSet<Orcamento> Orcamento {  get; set; }

        public DbSet<Tipo_de_Artigos> Tipo_de_Artigos {  get; set; }

        public DbSet<Utilizadores> Utilizadores {  get; set; }

    }
}
