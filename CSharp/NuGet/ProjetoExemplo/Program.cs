using Newtonsoft.Json;
using ProjetoExemplo.models;

var produto = new Produto
{
    Nome = "Notebook",
    Valor = 2500m,
    Estoque = 10,
    Categoria = "Informática"
};

var json = JsonConvert.SerializeObject(produto);
Console.WriteLine(json);
