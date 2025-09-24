namespace ProjetoExemplo.models;

public class Produto
{
    public string Nome { get; set; } = string.Empty; // Inicializa com string vazia para evitar null
    // public string? Nome { get; set; } // Permite null (usar se o nome puder ser nulo)
    public decimal Valor { get; set; }
    public int Estoque { get; set; }
    public string Categoria { get; set; } = string.Empty; // Inicializa com string vazia para evitar null
}