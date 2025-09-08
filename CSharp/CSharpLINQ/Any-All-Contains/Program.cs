using System;
using System.Collections.Generic;
using System.Linq;

namespace Any_All_Contains;

class Program
{
    private static List<int> notas = new List<int> { 500, 600, 700, 800, 900};
    static void Main(string[] args)
    {
        // retornar true se algum elemento da coleção for maior que 700
        var any = notas.Any(n => n > 700);
        Console.WriteLine("Any: " + any);

        // retornar true se todos os elementos da coleção forem maiores que 500
        var all = notas.All(n => n > 500);
        Console.WriteLine("All: " + all);

        // retornar true se a coleção contiver o valor 900
        var contains = notas.Contains(900);
        Console.WriteLine("Contains: " + contains);
    }
}
