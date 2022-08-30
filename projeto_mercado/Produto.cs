using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_mercado
{
     public class Produto
    {
        public string nome,subgrupo, grupo, medida, Armazenagem;
        public int Quantidade;
        public decimal precoCompra, perc_lucro,preco_Venda ;
        

        public void lerProduto()
        {
            Console.WriteLine("digite qual nome do produto");
            nome = Console.ReadLine();
            
            Console.WriteLine("digite qual nome do subgrupo");
            subgrupo = Console.ReadLine();

            Console.WriteLine("digite qual local da  Armazenagem");
            Armazenagem = Console.ReadLine();

            Console.WriteLine("digite qual nome do grupo");
            grupo = Console.ReadLine();
            
            Console.WriteLine("digite qual a medida ");
            medida = Console.ReadLine();
           
            Console.WriteLine("digite qual a Quantidade ");
            Quantidade = (int)Convert.ToInt64( Console.ReadLine());
            
            Console.WriteLine("digite qual preco da compra  ");
            precoCompra = (decimal)Convert.ToDecimal(Console.ReadLine());
            
            
            
            
            Console.WriteLine("digite valor do lucro ");

          
           perc_lucro = (decimal)Convert.ToDecimal(Console.ReadLine());

            preco_Venda = calcularVenda(perc_lucro);




        }

        public void escreverProduto()
        {
            Console.WriteLine("o nome do produto é: "+nome);
          

            Console.WriteLine("subgrupo é "+ subgrupo);
            

            Console.WriteLine("o grupo é"+grupo);
            

            Console.WriteLine("a medida é"+ medida);
          
            Console.WriteLine("a Armazenagem é "+Armazenagem);
          

            Console.WriteLine(" a Quantidade é" +Quantidade);
            

            Console.WriteLine(" preco da compra é "+precoCompra);
           
            Console.WriteLine("preço de venda "+preco_Venda);
           

            Console.WriteLine(" valor do lucro é " +perc_lucro);


            



        }

        public Decimal calcularVenda(decimal percentlucro) {

            return precoCompra + (precoCompra * (percentlucro / 100));
        }

    }
}
