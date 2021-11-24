using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO.Ecommerce
{
    internal abstract class Pagamento
    {
        public Pagamento(Epagamento e,decimal valor)
        {
            TipoPagamento = e;
            Valor=valor;
        }
        protected decimal Valor { get;private set; }
        protected DateTime DataPagamento { get; private set; }

        protected bool PagamentoConcluido { get;private set;}
        public bool Valido { get; set; }

        public Epagamento TipoPagamento { get; init; }

        internal abstract bool Validar();
        internal abstract bool Validar(out string s);
        public enum Epagamento
        {
            Pix,
            Boleto,
            CartaoDebito,
            CartaoCredito,
        }
    }

}
