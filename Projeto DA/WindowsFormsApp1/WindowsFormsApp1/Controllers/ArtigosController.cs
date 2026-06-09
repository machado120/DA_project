using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers
{

    internal class ArtigosController
    {
        internal void Add_Tipo_artigo(string Tipo)
        {
            using (Context context = new Context())
            {
                // 1. Procurar na base de dados se já existe alguém com este nome
                var ArtigoExiste = context.Tipo_de_Artigos.FirstOrDefault(u => u.descricao == Tipo);

                // 2. Se o utilizadorExiste NÃO for null, significa que já há um na base de dados
                if (ArtigoExiste != null)
                {
                    // Lançamos um erro. O teu bloco 'catch (InvalidOperationException ex)' 
                    // no Login.cs vai apanhar isto e mostrar a mensagem numa MessageBox!
                    MessageBox.Show("Já existe um tipo de artigo com esse nome!");
                    return;
                }

                // 3. Se passou pela verificação (não existe), cria e guarda o novo cliente
                Tipo_de_Artigos tipo_artigo = new Tipo_de_Artigos();
                tipo_artigo.descricao = Tipo;

                context.Tipo_de_Artigos.Add(tipo_artigo);
                context.SaveChanges();

            }
        }

        public List<Tipo_de_Artigos> Get_tipo_de_Artigos()
        {
            using (Context context = new Context())
            {
                return context.Tipo_de_Artigos.ToList();// to list para obrigar a converter 
            }
        }

        public void editar_Tipoartigo(Tipo_de_Artigos artig)
        {

            using (Context context = new Context())
            {
                context.Tipo_de_Artigos.AddOrUpdate(artig);
                context.SaveChanges();

            }
        }

        public void eliminar_Tipoartigo(Tipo_de_Artigos artig)
        {
            using (Context context = new Context())
            {
                var temArtigos = context.Artigos.Any(a => a.TipoArtigoId == artig.Id);
                if (temArtigos)
                {
                    MessageBox.Show("Não é possível eliminar um tipo com artigos associados.");
                    return;
                }
                context.Tipo_de_Artigos.Attach(artig);
                context.Tipo_de_Artigos.Remove(artig);
                context.SaveChanges();
            }
        }
        // Artigos
        public List<Artigos> GetArtigos()
        {
            using (Context context = new Context())
            {
                return context.Artigos.Include("TipoArtigo").ToList();// to list para obrigar a converter 
            }
        }
        public List<Artigos> GetArtigosPorTipo(int tipoId)
        {
            using (Context context = new Context())
            {
                return context.Artigos.Include("TipoArtigo").Where(a => a.TipoArtigoId == tipoId).ToList();
            }
        }
        public void AddArtigo(string nome, int tipoId)
        {
            using (Context context = new Context())
            {
                var existe = context.Artigos.FirstOrDefault(a => a.Nome == nome && a.TipoArtigoId == tipoId);
                if (existe != null)
                {
                    MessageBox.Show("Já existe um artigo com esse nome para este tipo!");
                    return;
                }
                context.Artigos.Add(new Artigos { Nome = nome, TipoArtigoId = tipoId });
                context.SaveChanges();
            }
        }
        public void EditarArtigo(Artigos artigo)
        {
            using (Context context = new Context())
            {
                context.Artigos.AddOrUpdate(artigo);
                context.SaveChanges();
            }
        }
        public void EliminarArtigo(Artigos artigo)
        {
            using (Context context = new Context())
            {
                var temItens = context.Items.Any(i => i.ArtigoId == artigo.Id);
                if (temItens)
                {
                    MessageBox.Show("Não é possível eliminar um artigo associado a compras.");
                    return;
                }
                context.Artigos.Attach(artigo);
                context.Artigos.Remove(artigo);
                context.SaveChanges();
            }
        }
    }
}
