using BancoDados.DAL;
using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.View
{
    class Busca
    {
        public static void BuscaProduto()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Produto p = new Produto();

            Console.WriteLine("Entre com o Nome ou Preço do Produto que deseja buscar: \n");
            p.NomeP = Console.ReadLine();
            //p.Preco = Convert.ToDouble(Console.ReadLine());

            p = ProdutoDAO.BuscarProduto(p);
            if(p != null)
            {
                Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine("Esse produto não existe!");
            }
        }

        public static void BuscarProdutoData()
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com a Data de cadastro do Produto, que deseja buscar: \n");
            p.CriadoEm = Convert.ToDateTime(Console.ReadLine());
            
            p = ProdutoDAO.BuscarData(p.CriadoEm);
            if (p != null)
            {
                Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine("Esse produto não existe!");
            }

        }
    }
}
