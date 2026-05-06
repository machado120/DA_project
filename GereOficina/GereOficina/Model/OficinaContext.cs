using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereOficina.Model
{
    public class OficinaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Servico> Servicos { get; set; }//DbSet é tabela
        public DbSet<Parcela> Parcelas { get; set; }

    }
}
