﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Models
{
    class Context : DbContext
    {
        //Nomear o arquivo de banco de dados
        public Context() : base("DbProdutos") { }

        //Definir as classes que vão virar tabelas no banco
        public DbSet<Produto> Produtos { get; set; }
    }
}
