using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class ArquivoTexto : IArmazenavel
    {
        public void Salvar(string conteudo)
        {
            Console.WriteLine($"Salvando arquivo de texto: {conteudo}");
        }

        public void Ler()
        {
            Console.WriteLine("Lendo arquivo de texto...");
        }
    }
}