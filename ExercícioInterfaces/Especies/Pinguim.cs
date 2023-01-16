using TreinamentoInterfaces.ExercícioInterfaces.ClassesBase;
using TreinamentoInterfaces.ExercícioInterfaces.Interfaces;

namespace TreinamentoInterfaces.ExercícioInterfaces.Especies
{
    public class Pinguim : Ave, IAquatico, IOviparo
    {
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
        public Pinguim(DateTime dataDeNascimento, char sexo)
        {
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = true;
            Peconhento = false;
            Rapina = false;
            CorPena = true;
            ViveEmTerra = true;
            Mergulho = true;
            AguaDoce = false;
        }

        public override void Movimentar()
        {
            Console.WriteLine("Movimentação: duas patas");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Comunicação: vocalizando e por linguagem corporal");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Alimentação: carnívoros");
        }

        public override void Ciscar()
        {
            Console.WriteLine("Ciscar: não cisca");
        }

        public void Botar()
        {
            Console.WriteLine("Botar: 2 ovos");
        }

        public void Chocar()
        {
            Console.WriteLine("Chocar: sim");
        }
    }
}
