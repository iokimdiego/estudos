using System;
using RH;

namespace Encapsulamento;

class Program
{
    static void Main(string[] args)
    {
        var funcionario = new Funcionario("João", "123.456.789-00");
        Console.WriteLine(funcionario.CPF);
        // funcionario.CPF = "111.111.111-11";
        funcionario.CPF = "";
        Console.WriteLine(funcionario.CPF);


    }
}
