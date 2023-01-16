using TreinamentoInterfaces.ExercícioInterfaces.ClassesBase;

namespace TreinamentoInterfaces.ExercícioInterfaces.Especies
{
    public class Elefante : Mamifero
    {
        public Elefante(DateTime dataDeNascimento, char sexo)
        {
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = false;
            Peconhento = false;
            QuantidadeDeMamas = 2;
            Pelos = true;
            CorDoPelo = "Cinza";
        }

        public override void Movimentar()
        {
            Console.WriteLine("Movimentação: 4 patas");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Comunicação: infrassom");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Alimentação: herbívoro");
        }

        public override void Amamentar()
        {
            Console.WriteLine("Amamentação: amamenta o elefante filhote");
        }
    }
}
