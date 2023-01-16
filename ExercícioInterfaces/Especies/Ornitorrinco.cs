using TreinamentoInterfaces.ExercícioInterfaces.ClassesBase;
using TreinamentoInterfaces.ExercícioInterfaces.Interfaces;

namespace TreinamentoInterfaces.ExercícioInterfaces.Especies
{
    public class Ornitorrinco : Mamifero, IAquatico, IOviparo
    {
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
        public Ornitorrinco(DateTime dataDeNascimento, char sexo)
        {
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            QuantidadeDeMamas = 0;
            Carnivoro = true;
            Peconhento = false;
            ViveEmTerra = true;
            Mergulho = true;
            AguaDoce = false;
        }

        public override void Movimentar()
        {
            Console.WriteLine("Movimentação: patas e nadadeiras");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Comunicação: eletricidade");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Alimentação: carnívoros");
        }

        public override void Amamentar()
        {
            Console.WriteLine("Amamentação: amamenta o ornitorrinco filhote, pelos poros e sulcos abdominais");
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
