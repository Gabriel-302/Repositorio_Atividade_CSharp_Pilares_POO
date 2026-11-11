using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public abstract class Equipamento
    {
        public string? Modelo { get; set; }
        protected int NumeroSerie { get; set; }

        public Equipamento(string modelo, int numeroSerie)
        {
            Modelo = modelo;
            NumeroSerie = numeroSerie;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}\nNúmero de Série: {NumeroSerie}");
        }
    }
}