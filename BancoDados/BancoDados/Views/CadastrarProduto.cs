﻿using BancoDados.DAL;
using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Views
{
    class CadastrarProduto
    {
        public static void Renderizar()
        {
            Produto p = new Produto();
            Console.Clear();
            Console.WriteLine(" -- CADASTRAR PRODUTO -- \n");
            Console.WriteLine("Digite o nome do produto:");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade do produto:");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o preco do produto:");
            p.Preco = Convert.ToDouble(Console.ReadLine());

            ProdutoDAO.CadastrarProduto(p);
            Console.WriteLine("Produto cadastrado com sucesso!");
        }
    }
}
