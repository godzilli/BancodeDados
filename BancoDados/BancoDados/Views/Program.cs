using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(" -- PROJETO DE BANCO DE DADOS -- \n");
                Console.ResetColor();
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Buscar produto por nome");
                Console.WriteLine("4 - Remover produto");
                Console.WriteLine("5 - Alterar produto");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nDigite a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CadastrarProduto.Renderizar();
                        break;
                    case 2:
                        ListarProdutos.Renderizar();
                        break;
                    case 3:
                        //CadastrarVendedor.Renderizar();
                        break;
                    case 4:
                        //ListarVendedores.Renderizar();
                        break;
                    case 5:
                        //CadastrarProduto.Renderizar();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("\nAperter uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);

        }
    }
}
