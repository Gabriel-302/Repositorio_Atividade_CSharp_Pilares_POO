using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class EntregaEconomica : Entrega
    {
        public override void CalcularFrete(decimal distancia)
        {
            Distancia = distancia;
            Valor = Distancia * 0.2m;
            Console.WriteLine($"Frete econômico: {Valor:C}.");
        }
    }
}