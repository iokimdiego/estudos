using System;
using RH;

namespace Encapsulamento;

class Program
{
    static void Main(string[] args)
    {
        var funcionario = new Funcionario("João", "123.456.789-00");
        // Acessando o CPF através do método público
        Console.WriteLine(funcionario.GetCPF());
        funcionario.SetCPF("987.654.321-00");
        // Acessando o CPF novamente para verificar a alteração
        Console.WriteLine(funcionario.GetCPF());
    
    }
}
