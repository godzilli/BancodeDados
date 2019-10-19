using BancoDados.DAL;
using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.View
{
    class Cadastro
    {
        public static void CadastroProduto()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Produto p = new Produto();

            Console.WriteLine("~~ CADASTRO ~~ !");

            Console.WriteLine("Nome do produto:");
            p.NomeP = Console.ReadLine();
            Console.WriteLine("Preço:");
            p.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantide:");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Categoria:");
            p.Categoria.Nome= Console.ReadLine();

            ProdutoDAO.CadastrarProduto(p);
            Console.WriteLine("Produto cadastrado com sucesso!");
        }
    }
}
