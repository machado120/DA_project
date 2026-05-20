using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    throw new InvalidOperationException("Já existe um tipo de artigo com esse nome!");
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
    }
}
