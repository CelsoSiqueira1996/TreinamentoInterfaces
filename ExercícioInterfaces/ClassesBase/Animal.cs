namespace TreinamentoInterfaces.ExercícioInterfaces.ClassesBase
{
    public abstract class Animal
    {
        public string? Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public char Sexo { get; set; }
        public bool Carnivoro { get; set; }
        public bool Peconhento { get; set; }
        public int Idade()
        {
            return (int)Math.Floor((DateTime.Now - DataDeNascimento).TotalDays / 365);
        }
        public abstract void Movimentar();
        public abstract void Comunicar();
        public abstract void Alimentar();
    }
}
