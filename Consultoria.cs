using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class Consultoria : IContratavel
    {
        public void Contratar()
        {
            Console.WriteLine("Consultoria contratada.");
        }
    }
}