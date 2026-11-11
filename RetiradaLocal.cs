using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class RetiradaLocal : Entrega
    {
        public override void CalcularFrete(decimal distancia)
        {
            Distancia = distancia;
            Valor = 0;
            Console.WriteLine($"Retirada local sem frete: {Valor:C}.");
        }
    }
}