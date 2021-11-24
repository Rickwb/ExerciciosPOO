using System;
namespace Pontos
{
    public class Ponto
    {
        public Ponto(int x, int y)
        {
            X = x;
            Y = y;
        }
        private int _X { get; set; }
        private int _Y { get; set; }
        public int X {
            get => _X;
            set
            {
                if (value > 1 && value < 44)
                    _X = value;
            } }
        public int Y {
            get => _Y; set
            {
                if (value > -13 && value < 256)
                    _Y = value;
            }
        }

        public static bool operator ==(Ponto direito, Ponto esquerdo)
        {

            return direito.X == esquerdo.X && direito.Y == esquerdo.Y ? true : false;


        }
        public static bool operator !=(Ponto direito, Ponto esquerdo)
        {
            return direito.X != esquerdo.X && direito.Y != esquerdo.Y ? true : false;
        }


    }



}


