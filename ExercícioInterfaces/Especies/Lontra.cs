using TreinamentoInterfaces.ExercícioInterfaces.ClassesBase;
using TreinamentoInterfaces.ExercícioInterfaces.Interfaces;

namespace TreinamentoInterfaces.ExercícioInterfaces.Especies
{
    public class Lontra : Mamifero, IAquatico
    {
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
        public Lontra(DateTime dataDeNascimento, char sexo)
        {
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = true;
            Peconhento = false;
            QuantidadeDeMamas = 4;
            Pelos = true;
            CorDoPelo = "Marrom acinzentado";
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
            Console.WriteLine("Comunicação: por meio de sinais auditivos e olfativos");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Alimentação: carnívoras");
        }

        public override void Amamentar()
        {
            Console.WriteLine("Amamentação: amamenta a lontra filhote");
        }
    }
}
