using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO.Ecommerce
{
    internal class Boleto : Pagamento
    {
        public Boleto(Epagamento e, decimal valor) : base(e, valor)
        {

        }

        public DateTime Vencimento { get; set; }
        public decimal Multa { get; set; }
        public string Benefinciario { get; set; }
        public string NumDocumento { get; set; }
        public string Agencia { get; set; }
        public string NumBanco { get; set; }

        internal override bool Validar()
        {
            try
            {
                if (string.IsNullOrEmpty(NumBanco) || string.IsNullOrEmpty(Agencia) || string.IsNullOrEmpty(Benefinciario)
                    || Vencimento == DateTime.MinValue || String.IsNullOrEmpty(NumDocumento) || Valor == 0)
                {
                    throw new ArgumentNullException("Campos");
                }
                if (Vencimento < DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("A não é possivel criar um boleto com o vencimento anterior ao dia atual");
                }
                return true;
            }
            catch (ArgumentNullException a)
            {
                return false;
            }
            catch (ArgumentOutOfRangeException a)
            {
                return false;
            }
        }

        internal override bool Validar(out string s)
        {
            try
            {
                if (string.IsNullOrEmpty(NumBanco) || string.IsNullOrEmpty(Agencia) || string.IsNullOrEmpty(Benefinciario)
                    || Vencimento == DateTime.MinValue || String.IsNullOrEmpty(NumDocumento) || Valor == 0)
                {
                    throw new ArgumentNullException("Campos");
                }
                if (Vencimento < DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("A não é possivel criar um boleto com o vencimento anterior ao dia atual");
                }
                s = "Validado";
                return true;
            }
            catch (ArgumentNullException a)
            {
                s = a.Message;
                return false;
            }
            catch (ArgumentOutOfRangeException a)
            {
                s = a.Message;
                return false;
            }

        }
    }
}
