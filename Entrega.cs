namespace ExercicioPOO
{
    public abstract class Entrega
    {
        public decimal Distancia { get; set; }
        public decimal Valor { get; set; }
        public abstract void CalcularFrete(decimal distancia);
    }
}