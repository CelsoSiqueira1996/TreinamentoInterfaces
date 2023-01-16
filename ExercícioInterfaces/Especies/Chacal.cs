using TreinamentoInterfaces.ExercícioInterfaces.ClassesBase;

namespace TreinamentoInterfaces.ExercícioInterfaces.Especies
{
    public class Chacal : Mamifero
    {
        public Chacal(DateTime dataDeNascimento, char sexo)
        {
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = true;
            Peconhento = false;
            QuantidadeDeMamas = 4;
            Pelos = true;
            CorDoPelo = "Laranja";
        }

        public override void Movimentar()
        {
            Console.WriteLine("Movimentação: 4 patas");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Comunicação: Latindo");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Alimetação: onívaros");
        }

        public override void Amamentar()
        {
            Console.WriteLine("Amamentação: amamenta o chacal filhote");
        }
    }
}
