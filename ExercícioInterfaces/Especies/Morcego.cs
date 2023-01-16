using TreinamentoInterfaces.ExercícioInterfaces.ClassesBase;
using TreinamentoInterfaces.ExercícioInterfaces.Interfaces;

namespace TreinamentoInterfaces.ExercícioInterfaces.Especies
{
    public class Morcego : Mamifero, IVoar
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public Morcego(DateTime dataDeNascimento, char sexo)
        {
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = true;
            Peconhento = false;
            QuantidadeDeMamas = 4;
            Pelos = true;
            CorDoPelo = "Marrom escuro";
            AltitudeMaximaEmMetros = 1000;
            VelocidadeDoVoo = 160D;
        }

        public override void Movimentar()
        {
            Console.WriteLine("Movimentação: voando");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Comunicação: ecolocalizaçã");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Alimentação: onívoros");
        }

        public override void Amamentar()
        {
            Console.WriteLine("Amamentação: amamenta o morcego filhote");
        }

        public void Voar()
        {
            Console.WriteLine($"Altitude máxima voando: {AltitudeMaximaEmMetros} metros de altura\n Velocidade máxima voando: {VelocidadeDoVoo} km/h ");
        }
    }
}
