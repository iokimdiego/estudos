using System;
using System.Linq;
using System.Colections.Generic;

namespace Distinct
{
    class Program
    {
        private static List<Produto> produtos = new List<Produto>
        {
            new produto { Descricao = "Desinfetante", Categoria = "Limpeza", Preco = 3.99m},
            new produto { Descricao = "Feijão", Categoria = "Cereais", Preco = 8.19m},
            new produto { Descricao = "Detergente", Categoria = "Limpeza", Preco = 2.29m},
            new produto { Descricao = "Arroz", Categoria = "Cereais", Preco = 4.89m},

        };

        static void Main(string[] args)
        {
            var categorias = produtos.Select(p => p.Categoria).Distinct();

            foreach (var c in categorias)
            {
                Console.WriteLine(c);
            }
        }
    }
}