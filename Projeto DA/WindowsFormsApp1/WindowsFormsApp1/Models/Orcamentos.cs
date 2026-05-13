using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Orcamento
    {
        // The [Key] attribute explicitly tells Entity Framework this is the Primary Key & Identity
        public int Id { get; set; }

        public int Mes { get; set; } // Mês de referência (1-12)

        public int Ano { get; set; } // Ano de referência

        public decimal ValorMaximo { get; set; } // O orçamento estipulado

        // --- (Chaves Estrangeiras) ---
        public int CriadoPorUtilizadorId { get; set; }

        public int AlteradoPorUtilizadorId { get; set; }
    }
}
