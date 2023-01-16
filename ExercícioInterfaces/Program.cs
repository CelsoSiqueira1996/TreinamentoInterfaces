using System;
using TreinamentoInterfaces.ExercícioInterfaces.Especies;
using TreinamentoInterfaces.ExercícioInterfaces.ClassesBase;

public class TesteInterfacesAnimais
{
    static void Main(string[] args)
    {
        Animal ornitorrinco = new Ornitorrinco(new DateTime(2019, 03, 25), 'M')
        {
            Nome = "Orno",
        };
        Console.WriteLine($"Nome: {ornitorrinco.Nome}");
        Console.WriteLine($"Data de Nascimento: {ornitorrinco.DataDeNascimento}");
        Console.WriteLine($"Sexo: {ornitorrinco.Sexo}");
        Console.WriteLine($"Carnívoro: {ornitorrinco.Carnivoro}");
        Console.WriteLine($"Peçonhento: {ornitorrinco.Peconhento}");
        Console.WriteLine($"Idade: {ornitorrinco.Idade()}");
    }
}
