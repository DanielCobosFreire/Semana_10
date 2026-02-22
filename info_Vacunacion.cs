using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        // Crear conjunto ficticio de 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // Crear conjunto ficticio de 75 ciudadanos vacunados con Pfizer
        HashSet<string> vacunadosPfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            vacunadosPfizer.Add("Ciudadano " + i);
        }

        // Crear conjunto ficticio de 75 ciudadanos vacunados con AstraZeneca
        HashSet<string> vacunadosAstraZeneca = new HashSet<string>();
        for (int i = 50; i < 125; i++) // Se solapan algunos con Pfizer
        {
            vacunadosAstraZeneca.Add("Ciudadano " + i);
        }

        // Operaciones de teoría de conjuntos

        // 1. Ciudadanos que no se han vacunado
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunadosPfizer);
        noVacunados.ExceptWith(vacunadosAstraZeneca);

        // 2. Ciudadanos que han recibido ambas dosis (Pfizer y AstraZeneca)
        HashSet<string> ambasDosis = new HashSet<string>(vacunadosPfizer);
        ambasDosis.IntersectWith(vacunadosAstraZeneca);

        // 3. Ciudadanos que solo han recibido la vacuna de Pfizer
        HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstraZeneca);

        // 4. Ciudadanos que solo han recibido la vacuna de AstraZeneca
        HashSet<string> soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
        soloAstraZeneca.ExceptWith(vacunadosPfizer);

        // Mostrar resultados
        Console.WriteLine("\n--- Ciudadanos que NO se han vacunado ---");
        foreach (var c in noVacunados)
            Console.WriteLine(c);

        Console.WriteLine("\n--- Ciudadanos con ambas dosis ---");
        foreach (var c in ambasDosis)
            Console.WriteLine(c);

        Console.WriteLine("\n--- Ciudadanos solo con Pfizer ---");
        foreach (var c in soloPfizer)
            Console.WriteLine(c);

        Console.WriteLine("\n--- Ciudadanos solo con AstraZeneca ---");
        foreach (var c in soloAstraZeneca)
            Console.WriteLine(c);
    }
}
