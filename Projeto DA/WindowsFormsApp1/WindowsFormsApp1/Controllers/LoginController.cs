using System;
using System.Collections.Generic;
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
            // do the comparision to check if there is alr a user with thisname on the dataset

            using (Context context = new Context())
            {
                //criacao do objeto cliente
                Utilizadores cliente = new Utilizadores();
                cliente.Nome = nome;
                cliente.password = password;

                context.Utilizadores.Add(cliente);
                context.SaveChanges();
                MessageBox.Show("susesso");
            }

        }

        public string VerificarPass(string nome, string password)
        {

            using (Context context = new Context())
            {
                // Procura o primeiro utilizador que tenha o Nome igual ao fornecido
                var utilizador = context.Utilizadores.FirstOrDefault(u => u.Nome == nome);

                // Se o utilizador for null, significa que não existe na base de dados
                if (utilizador == null)
                {
                    return "Utilizador não encontrado";
                }
                // Se encontrou o utilizador, compara as passwords
                if (utilizador.password == password)
                {

                    return "Sucesso";
                }
                else
                {
                    return "Password incorreta";
                }
            }
        }
    }
}
