using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereOficina.Model
{
    public class Carro
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public Cliente Dono { get; set; } //o 2ºCliente é dono

        public List<Servico> Servicos { get; set; }


    }
}
