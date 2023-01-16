using TreinamentoInterfaces.ExercícioInterfaces.ClassesBase;

namespace TreinamentoInterfaces.ExercícioInterfaces.Especies
{
    public class Leao : Mamifero
    {
        public Leao(DateTime dataDeNascimento, char sexo)
        {
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = true;
            Peconhento = false;
            QuantidadeDeMamas = 4;
            Pelos = true;
            CorDoPelo = "Dourado";
        }

        public override void Movimentar()
        {
            Console.WriteLine("Movimentação: 4 patas");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Comunicação: Rugindo");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Alimentação: carnívoros");
        }

        public override void Amamentar()
        {
            Console.WriteLine("Amamentação: amamenta o leao filhote");
        }
    }
}
