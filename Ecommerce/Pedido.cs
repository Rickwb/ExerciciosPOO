using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO.Ecommerce
{
    internal class Pedido
    {
        private List<Produto> _produtos { get; set; }
        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            _produtos ??= new List<Produto>();
        }
        public Pedido(Cliente cliente,List<Produto>? produtos)
        {
            Cliente = cliente;
            _produtos??=new List<Produto> (produtos);
        }
        public Cliente Cliente { get; set; }    
        public IReadOnlyList<Produto> Produtos { get=>_produtos;  }
        public Pagamento TipoPagamento { get; set; }    

        public void AdicionarProduto(Produto prod)
        {
            
            _produtos.Add(prod);
        }
        public void RemoverProduto(Produto produto)
        {
            _produtos.Remove(produto);
        }
        public override string ToString()
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendLine("Cliente:");
            strB.AppendLine(Cliente.Id + ";" + Cliente.Nome + ";" + Cliente.Cpf + ";" + Cliente.Idade);
            strB.AppendLine("Produtos:");
            _produtos.ForEach(o => strB.AppendLine(o.Nome + ";" + o.Estoque + ";" + o.Valor + ";" + o.ID + ";" + o.Foto));
            strB.AppendLine(" ");
            strB.AppendLine(TipoPagamento.TipoPagamento+";"+TipoPagamento.Valido);

            return strB.ToString();
        }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
    }
}
