using GereOficina.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereOficina.Controller
{
    public class Oficinacontroller
    {
        public void AdicionarCliente(string nome, string nif)
        {
            if(nif.Count() != 9)//verificar se o nif tem 9 digitos, caso contrario lança uma exceção

            {
                throw new InvalidOperationException("Nif tem de conter 9 digitos");
            }
            using (OficinaContext context = new OficinaContext())
            {
                //criacao do objeto cliente
                Cliente cliente = new Cliente();
                cliente.Nome = nome;
                cliente.Nif = nif;

                context.Clientes.Add(cliente);
                context.SaveChanges();
            }

        }

        internal void RemoverCliente(int id)
        {
            using (OficinaContext context = new OficinaContext())
            {
                   Cliente cliente = context.Clientes.Where(c => c.Id == id).First();
                   context.Clientes.Remove(cliente);

                   context.SaveChanges();
                
            }
        }
    }
}
