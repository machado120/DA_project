using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

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
            }

        }

    }
}
