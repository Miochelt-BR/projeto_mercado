using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_mercado
{
    internal class Alimentos:Produto
    {
        public string validade;
        //public DateTime validade;
        public void guardarvalidade()
        {
            Console.WriteLine("digite a validade ");
            validade = Console.ReadLine();

        } 
    }
}
