using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Models
{
    // : herança
    class Context : DbContext
    {

        public Context() : base("DbProdutos") { }
        #region
        //Nomea o Arquivo de banco de dados
        //chama o construtor da classe Pai como fazia com o Super em Java
        #endregion

        //Definir as classes  que vão virar tabelas no banco
        public DbSet<Produto> Produtos { get; set; }
        #region
        // <> Do tipo da nossa classe, no caso "Produto" e Produtos é o nome da Tabela
        //sem ligação com o noe da Tabela "Produtos" qual esta nomeada na classe Produto.cs
        #endregion
        public DbSet<Categoria> Categorias { get; set; }
    }
}
