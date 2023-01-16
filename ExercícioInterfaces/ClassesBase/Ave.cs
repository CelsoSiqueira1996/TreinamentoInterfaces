namespace TreinamentoInterfaces.ExercícioInterfaces.ClassesBase
{
    public abstract class Ave : Animal
    {
        public bool Rapina { get; set; }
        public bool CorPena { get; set; }
        public abstract void Ciscar();
    }
}
