using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Item
    {

        public int Id { get; set; }

        // --- Foreign Keys ---
        public int CompraId { get; set; } // Connects to the main Compra (Shopping List)

        public int ArtigoId { get; set; } // Connects to the Artigo (Product) being bought

        // --- Values ---
        public decimal QuantidadePrevista { get; set; } // O que se planeou comprar

        public decimal QuantidadeAdquirida { get; set; } // O que foi realmente comprado

        public decimal PrecoUnitario { get; set; } // Preço pago

        // --- Special Types ---

        // In SQL this is a "BIT" (0 or 1). In C#, we use "bool" (false or true).
        public bool E_Previsto { get; set; }

        // The "?" after string means this field is Nullable (it can be left empty), 
        // matching the rule we defined for the database.
        public string Observacoes { get; set; }

        [ForeignKey("ArtigoId")]
        public virtual Artigos Artigos { get; set; } // Navigation property to access the related Artigo details
        
        
    }
}
