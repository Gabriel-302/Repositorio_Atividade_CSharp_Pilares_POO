using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class Passaro : Animal
    {
        public Passaro(string nome) : base(nome)
        {
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Piu piu!");
        }
    }
}