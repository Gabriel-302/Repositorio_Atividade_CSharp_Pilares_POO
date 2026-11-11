using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public abstract class Entrega
    {
        public decimal Distancia { get; set; }
        public decimal Valor { get; set; }
        public abstract void CalcularFrete(decimal distancia);
    }
}