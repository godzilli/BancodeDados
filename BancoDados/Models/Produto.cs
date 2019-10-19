using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Models {

    //define o nome da tabela no banco
    [Table("Produtos")]

    class Produto
    {
        public Produto(string nomeP, float preco)
        {
            NomeP = NomeP;
            Preco = Preco;

        }

        public Produto()
        {
            CriadoEm = DateTime.Now;
        }


        public override bool Equals(object obj)
        {
            Produto produto = (Produto)obj;
            if (produto.NomeP.Equals(NomeP))
            {
                return true;
            }
            return false;
        }

        #region
        //com esse [key] ele indica que tem uma chave primaria com qualquer nome sem precisar ter Id no nome
        //Sera autoincrementado e precisa ser Int para isso ocorrer
        #endregion
        [Key]
        public int ProdutoId { get; set; }
        public string NomeP { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }
        public Categoria Categoria { get; set; }
        
        public override string ToString()
        {
            return "Nome: " + NomeP + "| Preço: " + Preco.ToString("C2") + " | Categoria" + Categoria.Nome;
        }
    }
}
