namespace ExercicioPOO
{
    public abstract class Jogo
    {
        public string? Nome { get; set; }

        protected string? Plataforma { get; set; }

        public abstract void ExibirInformacoes(string plataforma, string genero, int id);
    }
}