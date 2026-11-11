using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class BancoDados : IArmazenavel
    {
        public void Salvar(string conteudo)
        {
            Console.WriteLine($"Salvando dados do banco de dados: {conteudo}");
        }

        public void Ler()
        {
            Console.WriteLine("Lendo dados do banco de dados...");
        }
    }
}