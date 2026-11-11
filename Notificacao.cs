using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public abstract class Notificacao
    {
        public virtual void Enviar(string mensagem)
        {
            if (!string.IsNullOrEmpty(mensagem) && mensagem.Length > 0)
            {
                Console.WriteLine($"Mensagem enviada: {mensagem}");
            }
            else
            {
                Console.WriteLine("Mensagem inválida. Não é possível enviar uma mensagem vazia.");
            }
        }
    }
}