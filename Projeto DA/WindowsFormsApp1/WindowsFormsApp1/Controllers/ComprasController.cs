using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using System.Data.Entity;

namespace WindowsFormsApp1.Controllers
{
    internal class ComprasController
    {
        public List<Compras> GetCompras() // Listar todas as compras
        {
            using (Context context = new Context())
            {
                return context.Compras.ToList();
            }
        }

        public List<Compras> GetComprasAbertas() // Listar apenas as compras que não estão fechadas
        {
            using (Context context = new Context())
            {
                return context.Compras.Where(c => !c.EstaFechada).ToList(); // Filtra as compras para retornar apenas as que não estão fechadas
            }
        }

        public Compras CriarCompra(string nome, int userId)// Criar uma nova compra com o nome fornecido e associá-la ao utilizador que a criou
        {
            using (Context context = new Context())
            {
                var compra = new Compras
                {
                    NomeCompra = nome,
                    DataCriacao = DateTime.Now,
                    DataAlteracao = DateTime.Now,
                    EstaFechada = false,
                    CriadaPorUtilizadorId = userId,
                    AlteradaPorUtilizadorId = userId
                };
                context.Compras.Add(compra);
                context.SaveChanges();
                return compra;
            }
        }

        public void EditarCompra(Compras compra, string novoNome, int userId)// Editar o nome de uma compra existente e atualizar a data de alteração e o utilizador que fez a alteração
        {
            using (Context context = new Context())
            {
                var c = context.Compras.Find(compra.Id);
                c.NomeCompra = novoNome;// Atualiza o nome da compra
                c.DataAlteracao = DateTime.Now;
                c.AlteradaPorUtilizadorId = userId;
                context.SaveChanges();
            }
        }

        public void EliminarCompra(Compras compra)
        {
            using (Context context = new Context())
            {
                var itens = context.Items.Where(i => i.CompraId == compra.Id).ToList();
                context.Items.RemoveRange(itens);
                var c = context.Compras.Find(compra.Id);
                context.Compras.Remove(c);
                context.SaveChanges();
            }
        }

        public void AddItem(int compraId, int artigoId, decimal qtdPrevista, decimal preco = 0)// Adicionar um item a uma compra existente, associando-o ao artigo correspondente e definindo a quantidade prevista
        {
            using (Context context = new Context())
            {
                context.Items.Add(new Item// Cria um novo item e associa-o à compra e ao artigo correspondentes, definindo a quantidade prevista
                {
                    CompraId = compraId,
                    ArtigoId = artigoId,
                    QuantidadePrevista = qtdPrevista,
                    QuantidadeAdquirida = 0,
                    PrecoUnitario = preco,
                    E_Previsto = true
                });
                context.SaveChanges();
            }
        }

        public void RemoverItem(int itemId)
        {
            using (Context context = new Context())
            {
                var item = context.Items.Find(itemId);
                if (item != null)// Verifica se o item existe antes de tentar removê-lo
                {
                    context.Items.Remove(item);
                    context.SaveChanges();
                }
            }
        }

        public List<Item> GetItens(int compraId)
        {
            using (Context context = new Context())
            {
                return context.Items
                    .Include(i => i.Artigos)
                    .Include(i => i.Artigos.TipoArtigo)
                    .Where(i => i.CompraId == compraId)
                    .ToList();
            }
        }

        public void MarcarAdquirido(int itemId, decimal qtdAdquirida, decimal preco)// Marcar um item como adquirido, atualizando a quantidade adquirida e o preço unitário, e salvando as alterações na base de dados
        {
            using (Context context = new Context())//
            {
                var item = context.Items.Find(itemId);
                if (item == null) return;
                item.QuantidadeAdquirida = qtdAdquirida;
                item.PrecoUnitario = preco;
                context.SaveChanges();
            }
        }

        public void FecharCompra(Compras compra, int userId)
        {
            using (Context context = new Context())
            {
                var c = context.Compras.Find(compra.Id);
                if (c == null) return;
                c.EstaFechada = true;
                c.DataFecho = DateTime.Now;
                c.FechadaPorUtilizadorId = userId;
                context.SaveChanges();
            }
        }

        public void AddItemNaoPrevisto(int compraId, int artigoId, decimal qtd, decimal preco, string observacoes = null)
        {
            using (Context context = new Context())
            {
                context.Items.Add(new Item
                {
                    CompraId = compraId,
                    ArtigoId = artigoId,
                    QuantidadePrevista = 0,
                    QuantidadeAdquirida = qtd,
                    PrecoUnitario = preco,
                    E_Previsto = false,
                    Observacoes = observacoes
                });
                context.SaveChanges();
            }
        }
        public List<Compras> GetComprasFechadas()
        {
            using (Context context = new Context())
            {
                return context.Compras.Where(c => c.EstaFechada).ToList();
            }
        }
        public string GetNomeUtilizador(int userId)
        {
            using (Context context = new Context())
            {
                var u = context.Utilizadores.Find(userId);
                return u?.Username ?? userId.ToString(); // adapta "Nome" ao nome real da propriedade
            }
        }
    }
}

