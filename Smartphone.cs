namespace ExercicioPOO
{
    public class Smartphone : Equipamento
    {
        public int Armazenamento { get; set; }

        public Smartphone(string modelo, int numeroSerie, int armazenamento) : base(modelo, numeroSerie)
        {
            Armazenamento = armazenamento;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Armazenamento: {Armazenamento} GB");
        }
    }
}