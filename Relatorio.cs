using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class Relatorio : IExportavel, IImprimivel
    {
        public void Imprimir()
        {
            Console.WriteLine("Relatório impresso com sucesso!");
        }

        public void Exportar()
        {
            Console.WriteLine("Relatório exportado com sucesso!");
        }
    }
}