namespace ExercicioPOO
{
    public class Veiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Marca: {Marca}");
        }
    }
}