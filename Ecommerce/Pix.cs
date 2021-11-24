using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO.Ecommerce
{
    internal class Pix : Pagamento
    {
        public Pix(Epagamento e, decimal valor) : base(e, valor)
        {
        }

        public PixType TipoChave { get; set; }
        public string Chave { get; set; }
        public string Comentario { get; set; }

        internal override bool Validar(out string s)
        {
            try
            {

                if (Enum.IsDefined(TipoChave) || String.IsNullOrEmpty(Chave))
                {
                    throw new ArgumentNullException(); 
                }
                if (TipoChave == PixType.Telefone && Chave.Any(x=>char.IsLetter(x)))
                {
                    throw new ArgumentException("O telfone não pode conter letras");
                }
                if (TipoChave==PixType.Email && !Chave.Contains("@"))
                {
                    throw new ArgumentException("O email não foi informado corretamente");
                }
                if (TipoChave==PixType.Cpf)
                {
                    Chave = Chave.Trim().Replace(".", "").Replace("-", "");
                    if (Chave.Length != 11)
                        throw new ArgumentException("O Cpf foi informado incorretamente");
                }
                s = "Processo concluido";
                return true;
            }
            catch (ArgumentNullException a)
            {
                s = "Existem Campos Nulos";
                return false;
            }
            catch (ArgumentException x)
            {
                s = x.Message;
                return false;
            }
          
        }

        internal override bool Validar()
        {
            try
            {

                if (Enum.IsDefined(TipoChave) || String.IsNullOrEmpty(Chave))
                {
                    throw new ArgumentNullException();
                }
                if (TipoChave == PixType.Telefone && Chave.Any(x => char.IsLetter(x)))
                {
                    throw new ArgumentException("O telfone não pode conter letras");
                }
                if (TipoChave == PixType.Email && !Chave.Contains("@"))
                {
                    throw new ArgumentException("O email não foi informado corretamente");
                }
                if (TipoChave == PixType.Cpf)
                {
                    Chave = Chave.Trim().Replace(".", "").Replace("-", "");
                    if (Chave.Length != 11)
                        throw new ArgumentException("O Cpf foi informado incorretamente");
                }
                return true;
            }
            catch (ArgumentNullException a)
            {
                return false;
            }
            catch (ArgumentException x)
            {
                return false;
            }

        }
    }
    }
    public enum PixType
    {
        Email,
        Telefone,
        Cpf,
        ChaveAleatoria,
        QrCode
    }

