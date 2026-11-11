using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public abstract class Animal
    {
        public string? Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }

        public void Apresentar()
        {
            Console.WriteLine($"\nNome do animal é {Nome}.");
        }
        public abstract void EmitirSom();
    }
}