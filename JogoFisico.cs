using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class JogoFisico : Jogo
    {
        public override void ExibirInformacoes(string plataforma, string genero, int id)
        {
            Plataforma = plataforma;

            Console.WriteLine($"FÍSICO - ID: {id} | Nome: {Nome} | Plataforma: {Plataforma} | Gênero: {genero}");
        }
    }
}