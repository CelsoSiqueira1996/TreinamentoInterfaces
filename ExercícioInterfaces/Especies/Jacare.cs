using TreinamentoInterfaces.ExercícioInterfaces.ClassesBase;
using TreinamentoInterfaces.ExercícioInterfaces.Interfaces;

namespace TreinamentoInterfaces.ExercícioInterfaces.Especies
{
    public class Jacare : Reptil, IAquatico, IOviparo
    {
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
        public Jacare(DateTime dataDeNascimento, char sexo)
        {
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = true;
            Peconhento = false;
            TemCasco = false;
            TemEscamas = true;
            ViveEmTerra = true;
            Mergulho = true;
            AguaDoce = true;
        }

        public override void Movimentar()
        {
            Console.WriteLine("Movimentação: 4 patas");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Comunicação: tosses, grunhidos e outras vocalizações");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Alimentação: carnívoros");
        }

        public void Botar()
        {
            Console.WriteLine("Botar: de 20 a 40 ovos");
        }

        public void Chocar()
        {
            Console.WriteLine("Chocar: sim");
        }
    }
}
