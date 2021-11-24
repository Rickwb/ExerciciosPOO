using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO.Ecommerce
{
    internal class CartaoDebito : Pagamento
    {
        public CartaoDebito(Epagamento e, decimal valor) : base(e, valor)
        {
        }

        public string NomeCartao { get; set; }
        public string NumCartao { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public int CVV { get; set; }
        public decimal Limite { get; set; }
        public DateTime DataValidade { get; set; }
        public string NumBanco { get; set; }
        public string MarcaCartao { get; set; }
        public decimal Saldo { get; set; }

        internal override bool Validar()
        {
            try
            {
                if (string.IsNullOrEmpty(NumBanco) || string.IsNullOrEmpty(Agencia) || string.IsNullOrEmpty(Conta) || CVV == 0 || Limite == 0)
                {
                    throw new ArgumentNullException("Campos");
                }
                if (Agencia.Length != 5 || Conta.Length != 6 || DataValidade < DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("Valores invalidos");
                }
                if ((Valor != 0 && Valor > Limite) || Valor == 0)
                {
                    throw new ArgumentOutOfRangeException("VALOR Maior que o limite");
                }
                return true;
            }
            catch (ArgumentOutOfRangeException a)
            {
                return false;
            }
            catch (ArgumentNullException e)
            {
                return false;

            }
        }

        internal override bool Validar(out string s)
        {
            try
            {
                if (string.IsNullOrEmpty(NumBanco) || string.IsNullOrEmpty(Agencia) || string.IsNullOrEmpty(Conta) || CVV == 0 || Limite == 0)
                {
                    throw new ArgumentNullException("Campos");
                }
                if (Agencia.Length != 5 || Conta.Length != 6 || DataValidade < DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("Valores invalidos");
                }
                if ((Valor != 0 && Valor > Limite) || Valor == 0)
                {
                    throw new ArgumentOutOfRangeException("VALOR Maior que o limite");
                }
                s = "Processo Concluido";
                return true;
            }
            catch (ArgumentOutOfRangeException a)
            {
                s = a.Message;
                return false;
            }
            catch (ArgumentNullException e)
            {
                s=e.Message;
                return false;

            }

        }
    }
}
