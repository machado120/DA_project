using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Controllers
{
    internal class LoginController
    {
        public void AdicionarCliente(string nome, string password)
        {
            using (Context context = new Context())
            {
                // 1. Procurar na base de dados se já existe alguém com este nome
                var utilizadorExiste = context.Utilizadores.FirstOrDefault(u => u.Nome == nome);

                // 2. Se o utilizadorExiste NÃO for null, significa que já há um na base de dados
                if (utilizadorExiste != null)
                {
                    // Lançamos um erro. O teu bloco 'catch (InvalidOperationException ex)' 
                    // no Login.cs vai apanhar isto e mostrar a mensagem numa MessageBox!
                    throw new InvalidOperationException("Já existe um utilizador com esse nome!");
                }

                // 3. Se passou pela verificação (não existe), cria e guarda o novo cliente
                Utilizadores cliente = new Utilizadores();
                cliente.Nome = nome;
                cliente.password = password;

                context.Utilizadores.Add(cliente);
                context.SaveChanges();

            }
        }




        public Utilizadores VerificarPass(string nome, string password)
        {

            using (Context context = new Context())
            {
                // Procura o primeiro utilizador que tenha o Nome igual ao fornecido
                var utilizador = context.Utilizadores.FirstOrDefault(u => u.Nome == nome);

                // Se o utilizador for null, significa que não existe na base de dados
                if (utilizador == null)
                {
                    return null;
                }
                // Se encontrou o utilizador, compara as passwords
                if (utilizador.password == password)
                {

                    return utilizador;
                }
                else
                {
                    return null;
                }
            }
        }


    public List<Utilizadores> GetUtilizadores() // Método para obter a lista de utilizadores
        {
            using (Context context = new Context())
            {
                return context.Utilizadores.ToList();
            }
        }

        public void EditarUtilizador(Utilizadores u) // Método para editar um utilizador existente
        {
            using (Context context = new Context())
            {
                context.Utilizadores.AddOrUpdate(u);
                context.SaveChanges();
            }
        }

        public void EliminarUtilizador(Utilizadores u) // Método para eliminar um utilizador existente
        {
            using (Context context = new Context())
            {
                context.Utilizadores.Attach(u);
                context.Utilizadores.Remove(u);
                context.SaveChanges();
            }
        }
    }
}

