using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Artigos
    {
        // Chave Primária e Auto-incremento
        public int Id { get; set; }
        public string Nome {  get; set; }

        // Nome do artigo (ex: "Leite Meio Gordo", "Maçãs")
        public int TipoArtigoId { get; set; }

        
        public virtual Tipo_de_Artigos TipoArtigo { get; set; }
    }
}
