namespace ExercicioPOO
{
    public class Notebook : Equipamento
    {
        public int MemoriaRAM { get; set; }

        public Notebook(string modelo, int numeroSerie, int memoriaRAM) : base(modelo, numeroSerie)
        {
            MemoriaRAM = memoriaRAM;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Memória RAM: {MemoriaRAM} GB");
        }
    }
}