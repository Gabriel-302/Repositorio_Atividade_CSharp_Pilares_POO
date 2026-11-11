using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class Hospedagem : IContratavel, ICancelavel
    {
        public void Contratar()
        {
            Console.WriteLine("Hospedagem contratada.");
        }
        public void Cancelar()
        {
            Console.WriteLine("Hospedagem cancelada.");
        }
    }
}