using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.View
{
    class Program
    {
        static void Main(string[] args)
        {

            
                Console.ForegroundColor = ConsoleColor.Cyan;
                int op = 0;
                do
                {
                    Console.Clear();

                    Console.WriteLine("~~~~~ MENU ~~~~ \n");
                    
                    Console.WriteLine("1 - Cadastrar Produto");
                    Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
                    Console.WriteLine("2 - Listar Produtos");
                    Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
                    Console.WriteLine("3 - Buscar Produto");
                    Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
                    Console.WriteLine("4 - Buscar por Data");
                    Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
                    Console.WriteLine("5 - Buscar por Categoria");
                    Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");

                Console.WriteLine("0 - Sair\n");

                    op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Cadastro.CadastroProduto();
                            break;
                        case 2:
                            Console.Clear();
                            Lista.ListarProduto();
                            break;
                        case 3:
                            Console.Clear();
                            Busca.BuscaProduto();
                        break;
                        case 4:
                            Console.Clear();
                            Busca.BuscarProdutoData();
                        break;
                        case 5:
                            //buscar categoria
                            break;
                    case 0:
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("\tEncerrando...");
                            Console.WriteLine("\nPressione uma tecla para continuar...");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Opção inválida.\n");
                            break;
                    }

                    Console.WriteLine("\nPressione uma tecla para continuar...");
                    Console.ReadKey();
                } while (op != 0);
            }
        
    }
}
