using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_mercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool produ=true;
            Alimentos mercado = new Alimentos ();
            mercado.lerProduto();
            List<Alimentos> lista = new List<Alimentos>();
            lista.Add(mercado);
            do
            {
                Console.WriteLine("cadastre o novo produto/n");
               mercado = new Alimentos (); 
                mercado.lerProduto ();
                mercado.guardarvalidade();
                lista.Add(mercado);
               Console.WriteLine("digite s para sair ou n para continuar ");

                var texto = Console.ReadLine();
                if (texto.ToLower() == "s") produ = false;
            } while (produ);
            lista.ForEach(obj => { obj.escreverProduto(); });
            Console.ReadLine();






        }
    }
}
