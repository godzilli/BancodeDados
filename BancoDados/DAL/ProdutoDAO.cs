using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.DAL
{
    class ProdutoDAO
    {
        #region Context
        //Objeto de contexto sempre necessaria para o manuseio com tabelas
        private static Context ctx = SingletonContext.GetInstance();
        #endregion

        //any informa se existe algum registro dentro de uma tabela ou busca
        //COunt informa a quantidade de registros dentro de uma tabela ou busca
        public static void CadastrarProduto(Produto p)
        {
            ctx.Produtos.Add(p);
            ctx.SaveChanges();
        }

        public static List<Produto> ListarProdutos() => ctx.Produtos.Include("Categoria").ToList();//nome do atributo que cria relacionamento
                                                                   // .Include("Categoria.o restando dos relacionamentos").ToList();
        public static Produto BuscarProduto(Produto p)
        {
            //retorna o PRIMEIRO objeto que foi encontrado na busca
            //x é o 'produtocadastrado' porem de forma mais simples na escrita
            return ctx.Produtos.FirstOrDefault(x => x.NomeP.Equals(p.NomeP) || x.Preco.Equals(p.Preco));

            //retorna o UNICO objeto que foi encontrado na busca
            //return ctx.Produtos.SingleOrDefault(x => x.NomeP.Equals(p.NomeP) || x.Preco.Equals(p.Preco));
        }
        
        public static Produto BuscarData(DateTime data)
        {
            return ctx.Produtos.FirstOrDefault(x => x.CriadoEm.Day == data.Day &&
                                                    x.CriadoEm.Month == data.Month &&
                                                    x.CriadoEm.Year == data.Year);
        }
        
        public static List<Produto> BuscarPorParte(Produto p)
        {
            //where retorna varios objetos numa busca
            return ctx.Produtos.Where(x => x.NomeP.Contains(p.NomeP)).ToList();
        }

        public static void RemoverProduto(Produto p)
        {
            ctx.Produtos.Remove(p);
            ctx.SaveChanges();
        }

        public static void AlterarProduto(Produto p)
        {
            ctx.Entry(p).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static double CalcularEstoque()
        {
            return ctx.Produtos.Sum(x => x.Quantidade * x.Preco);
        }
    }
   
}
