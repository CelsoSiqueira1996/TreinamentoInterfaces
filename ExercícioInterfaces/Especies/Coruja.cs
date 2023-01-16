using TreinamentoInterfaces.ExercícioInterfaces.ClassesBase;
using TreinamentoInterfaces.ExercícioInterfaces.Interfaces;

namespace TreinamentoInterfaces.ExercícioInterfaces.Especies
{
    public class Coruja : Ave, IOviparo, IVoar
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public Coruja(DateTime dataDeNascimento, char sexo)
        {
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = true;
            Peconhento = false;
            Rapina = true;
            CorPena = true;
            AltitudeMaximaEmMetros = 11270;
            VelocidadeDoVoo = 64.37d;
        }

        public override void Movimentar()
        {
            Console.WriteLine("Movimentação: duas patas e voando");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Comunicação: pios, assobios, estalos e chiados");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Alimentação: carnívoras");
        }

        public override void Ciscar()
        {
            Console.WriteLine("Ciscar: não cisca");
        }

        public void Botar()
        {
            Console.WriteLine("Botar: até 12 ovos");
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
