using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers
{
    internal class OrcamentosController
    {
        public List<Orcamento> GetOrcamentos()// Retorna todos os orçamentos, independentemente do mês ou ano
        {
            using (Context context = new Context())
            {
                return context.Orcamento.ToList();
            }
        }
        public Orcamento GetOrcamentoPorMes(int mes, int ano)// Adiciona o parâmetro ano para garantir que o orçamento é específico para o mês e ano
        {
            using (Context context = new Context())
            {
                return context.Orcamento.FirstOrDefault(o => o.Mes == mes && o.Ano == ano);// Retorna o orçamento específico para o mês e ano fornecidos
            }
        }
        public void CriarOrcamento(int mes, int ano, decimal valor, int userId) // Adiciona o userId como parâmetro para associar o orçamento ao utilizador
        {
            using (Context context = new Context())
            {
                Orcamento novoOrcamento = new Orcamento
                {
                    Mes = mes,
                    Ano = ano,
                    ValorMaximo = valor,
                    CriadoPorUtilizadorId = userId, // Define o userId do utilizador que criou o orçamento
                    AlteradoPorUtilizadorId = userId // Define o mesmo userId para criação e alteração, já que é um novo orçamento
                    
                };
                context.Orcamento.Add(novoOrcamento);
                context.SaveChanges();
            }
        }

        public void EditarOrcamento(Orcamento o, decimal novoValor, int userId) // Adiciona o userId como parâmetro para associar a edição do orçamento ao utilizador
        {
            using (Context context = new Context())
            {
                var orc = context.Orcamento.Find(o.Id); // Encontra o orçamento existente no banco de dados usando o ID do orçamento fornecido
                orc.ValorMaximo = novoValor; // Atualiza o valor máximo do orçamento
                orc.AlteradoPorUtilizadorId = userId; // Define o userId do utilizador que editou o orçamento
                context.SaveChanges();
            }

        }

        public void EliminarOrcamento(Orcamento o)
        {
            using (Context context = new Context())
            {
                var orc = context.Orcamento.Find(o.Id); // Encontra o orçamento existente no banco de dados usando o ID do orçamento fornecido
                if (orc != null)
                {
                    context.Orcamento.Remove(orc); // Remove o orçamento encontrado do banco de dados
                    context.SaveChanges(); // Salva as alterações no banco de dados
                    MessageBox.Show("Orçamento eliminado com sucesso!"); // Exibe uma mensagem de sucesso para o usuário
                }
            }
        }
    }
}