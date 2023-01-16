using TreinamentoInterfaces.ExercícioInterfaces.ClassesBase;
using TreinamentoInterfaces.ExercícioInterfaces.Interfaces;

namespace TreinamentoInterfaces.ExercícioInterfaces.Especies
{
    public class Cisne : Ave, IAquatico, IOviparo, IVoar
    {
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public Cisne(DateTime dataDeNascimento, char sexo)
        {
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = false;
            Peconhento = false;
            Rapina = false;
            CorPena = false;
            ViveEmTerra = true;
            Mergulho = true;
            AguaDoce = true;
            AltitudeMaximaEmMetros = 8200;
            VelocidadeDoVoo = 80d;
        }

        public override void Movimentar()
        {
            Console.WriteLine("Movimentação: duas patas e voando");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Comunicação: \"Quack!\"");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Alimentação: herbívoros");
        }

        public override void Ciscar()
        {
            Console.WriteLine("Ciscar: não cisca");
        }

        public void Botar()
        {
            Console.WriteLine("Botar: 4-8 ovos");
        }

        public void Chocar()
        {
            Console.WriteLine("Chocar: sim");
        }

        public void Voar()
        {
            Console.WriteLine($"Altitude máxima voando: {AltitudeMaximaEmMetros} metros de altura\n Velocidade máxima voando: {VelocidadeDoVoo} km/h ");
        }
    }
}
