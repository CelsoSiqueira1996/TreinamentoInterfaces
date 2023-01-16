using TreinamentoInterfaces.ExercícioInterfaces.ClassesBase;
using TreinamentoInterfaces.ExercícioInterfaces.Interfaces;

namespace TreinamentoInterfaces.ExercícioInterfaces.Especies
{
    public class DragaoDeKomodo : Reptil, IOviparo
    {
        public DragaoDeKomodo(DateTime dataDeNascimento, char sexo)
        {
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Carnivoro = true;
            Peconhento = true;
            TemCasco = true;
            TemEscamas = true;
        }

        public override void Movimentar()
        {
            Console.WriteLine("Movimentação: 4 patas");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Comunicação: ------");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Alimentação: carnívoros");
        }

        public void Botar()
        {
            Console.WriteLine("Botar: até 20 ovos");
        }

        public void Chocar()
        {
            Console.WriteLine("Chocar: não");
        }
    }
}
