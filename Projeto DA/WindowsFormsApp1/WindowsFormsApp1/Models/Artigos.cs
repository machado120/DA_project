using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class Artigos
    {
        public class Artigo
        {
            // Chave Primária e Auto-incremento
            [Key]
            public int Id { get; set; }

            // Nome do artigo (ex: "Leite Meio Gordo", "Maçãs")
            public string Nome { get; set; }

            // --- Chave Estrangeira ---
            // Relacionamento com a tabela TiposArtigo (Categoria do artigo)
            // Requisito #11: O artigo deve pertencer a um Tipo de Artigo
            public int TipoArtigoId { get; set; }
        }
    }
}
