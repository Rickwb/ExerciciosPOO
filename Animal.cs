using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public abstract class Animal
    {
        public Animal(string especie, string cor, int idade, bool tp,double peso)
        {
            TemPelo = tp;
            Especie = especie;
            Cor = cor;
            Idade = idade;
            Peso = peso;
        }
        public string Especie { get; set; }
        public string Cor { get; set; }
        public int Idade { get; set; }
        public bool TemPelo { get; set; }
        public double Peso { get; set; }
        public abstract string Falar();
        public abstract void Comer();

    }

    public class Cachorro : Animal
    {
        public Cachorro(string especie, string cor, int idade, bool tp,double p) : base(especie, cor, idade, tp,p)
        {
            
        }

        public override void Comer()
        {
            Peso += 0.4;
        }

        public override string Falar()
        {
            return "au au au";
        }
    }

    public class Pato : Animal
    {
        public Pato(string especie, string cor, int idade, bool tp,double p) : base(especie, cor, idade, tp,p)
        {
        }

        public override void Comer()
        {
            Peso += 0.3;
        }

        public override string Falar()
        {
            return "quack quack quack";
        }
    }

    public class Humano : Animal
    {
        public Humano(string especie, string cor, int idade, bool tp,double p) : base(especie, cor, idade, tp,p)
        {
        }

        public override void Comer()
        {
            Peso += 0.75;
        }

        public override string Falar()
        {
            return "Hello World";
        }
    }

    public class Gato : Animal
    {
        public Gato(string especie, string cor, int idade, bool tp,double peso) : base(especie, cor, idade, tp,peso)
        {
        }

        public override void Comer()
        {
            Peso += 0.5;
        }

        public override string Falar()
        {
            return "miau miau miau";
        }
    }

}
