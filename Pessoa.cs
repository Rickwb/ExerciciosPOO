using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Pessoa
    {

        private string _Nome { get; set; }
        private string _Sobrenome { get; set; }
        public string Nome
        {
            get
            {
                return _Nome;
            }
            private set
            {
                if (value.Length > 35)
                    this._Nome = value;
            }
        }
        public string Sobrenome
        {
            get
            { return this._Sobrenome; }
            private set
            {
                if (value.Length > 35)
                    this._Nome = value;

            }
        }
        public int Idade { get; set; }
        private string Documento { get; set; }
        public bool TemDoutorado { get; set; }
        public string ImprimirNome()
        {
            return String.Format("{0} {1}", this.Nome, this.Sobrenome).Trim();
        }
        public string ImprimirNome(bool NomePrimeiro)
        {
            if (NomePrimeiro)
                return String.Format("{0} {1}", this.Nome, this.Sobrenome).Trim();
            else
                return String.Format("{1} {0}", this.Nome, this.Sobrenome).Trim();
        }
        //Refazer
        public string ImprimirNome(bool NomePrimeiro,bool eDr)
        {
            if (eDr)
                return String.Format("Dr. {0} {1}", this.Nome, this.Sobrenome).Trim();
            else
                return String.Format("{1} {0}", this.Nome, this.Sobrenome).Trim();
        }

        public string ToString(Pessoa pessoa)
        {
            return String.Format("{0};{1};{2};{3}", this.Nome, this.Sobrenome, this.Idade, this.Documento);
        }

        public virtual string Trabalhar()
        {
            return "Estou Desempregado";
        }
        public override bool Equals(object? obj)
        {
            if (obj == this )
                return true;
            else
                return false;
        }
    }

    public class Medico : Pessoa
    {
        public override string Trabalhar()
        {
            return "Cuidar de Pessoas ";
        }
    }
    public class Programador : Pessoa
    {
        public override string Trabalhar()
        {
            return "Gerar bugs";
        }
    }
    public class Professor : Pessoa
    {
        public override string Trabalhar()
        {
            return "Ensinar pessoas";
        }
    }
}
