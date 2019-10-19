using BancoDados.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.View
{
    class Lista
    {
        public static void ListarProduto()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("~~ Lista de Produtos ~~ \n");

            int i = 0;

            foreach (var produto in ProdutoDAO.ListarProdutos())
            {
                i = i + 1;
                Console.WriteLine("Nome do Produto: " + produto.NomeP);
                Console.WriteLine("Preço: " + produto.Preco);
                Console.WriteLine("Quantidade: " + produto.Quantidade);
                Console.WriteLine("Categoria: " + produto.Categoria.Nome);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }
    }
}
