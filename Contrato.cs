using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class Contrato : IImprimivel
    {
        public void Imprimir()
        {
            Console.WriteLine("Contrato impresso com sucesso!");
        }
    }
}