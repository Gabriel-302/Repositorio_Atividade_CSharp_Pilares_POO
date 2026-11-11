using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class NotificacaoSMS : Notificacao
    {
        public override void Enviar(string mensagem)
        {
            if (!string.IsNullOrEmpty(mensagem) && mensagem.Length > 0)
            {
                Console.WriteLine($"Mensagem enviada por SMS: {mensagem}");
            }
            else
            {
                Console.WriteLine("Mensagem inválida. Não é possível enviar uma mensagem vazia.");
            }
        }
    }
}