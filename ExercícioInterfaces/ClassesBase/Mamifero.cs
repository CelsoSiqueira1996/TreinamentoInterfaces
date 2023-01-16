namespace TreinamentoInterfaces.ExercícioInterfaces.ClassesBase
{
    public abstract class Mamifero : Animal
    {
        public int QuantidadeDeMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorDoPelo { get; set; }
        public abstract void Amamentar();
    }
}
