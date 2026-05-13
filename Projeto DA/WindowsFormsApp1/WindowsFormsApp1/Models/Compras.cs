using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Compras
    {
        // Chave Primária e Auto-incremento
        public int Id { get; set; }

        // Nome da lista (ex: "Compras Semanais - Continente")
        // Como é uma string, na tua versão do C# não usas o "?"
        public string NomeCompra { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime DataAlteracao { get; set; }

        // DataFecho pode ser nula enquanto a compra estiver aberta.
        // Como DateTime é um "Value Type", o "?" funciona na tua versão 7.3.
        public DateTime? DataFecho { get; set; }

        // Estado: true se fechada, false se aberta
        public bool EstaFechada { get; set; }

        // --- Chaves Estrangeiras (Relacionamento com Utilizadores) ---

        public int CriadaPorUtilizadorId { get; set; }

        public int AlteradaPorUtilizadorId { get; set; }

        // O utilizador que fechou pode ser nulo se a compra ainda estiver aberta
        public int? FechadaPorUtilizadorId { get; set; }
    }
}
