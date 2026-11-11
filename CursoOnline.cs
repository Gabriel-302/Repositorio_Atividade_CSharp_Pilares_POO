namespace ExercicioPOO
{
    public class CursoOnline : ProdutoDigital
    {
        public int CargaHoraria{ get; set; }
        public CursoOnline(string nome, decimal preco, int cargaHoraria) : base(nome, preco)
        {
            CargaHoraria = cargaHoraria;
        }
    }
}