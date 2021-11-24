using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO.Ecommerce
{
    internal class Produto
    {
        public int? ID { get; set; }
        public string? Nome { get; set; }
        public string? Foto { get; set; }
        public int? Estoque { get; set; }
        public decimal? Valor { get; set; }
        //public Medidas? Medida { get; set; }
    }
    public struct Medidas
    {
        double altura { get; set; }
        double largura { get; set; }
        double comprimento { get; set; }
    }

}
