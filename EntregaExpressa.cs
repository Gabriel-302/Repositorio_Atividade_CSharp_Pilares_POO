using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class EntregaExpressa : Entrega
    {
        public override void CalcularFrete(decimal distancia)
        {
            Distancia = distancia;
            Valor = Distancia * 0.5m;
            Console.WriteLine($"Frete expresso: {Valor:C}.");
        }
    }
}