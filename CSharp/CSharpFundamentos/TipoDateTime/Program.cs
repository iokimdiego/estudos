namespace TipoDateTime;

class Program
{
    static void Main(string[] args)
    {
        var hoje = DateTime.Today; // Data de hoje
        var agora = DateTime.Now; // Data e hora atuais
        var data1 = new DateTime(2025, 05, 29); // Data específica
        var data2 = new DateTime(2025, 05, 29, 11, 25, 30); // Data e hora específicas
        var data3 = DateTime.Parse("15/08/2020"); // Data a partir de string
        var data4 = DateTime.Parse("15/08/2020 17:30:00"); // Data e hora a partir de string
                                                           // Console.WriteLine(hoje);
                                                           // Console.WriteLine(agora);
                                                           // Console.WriteLine(data1);
                                                           // Console.WriteLine(data2);
                                                           // Console.WriteLine(data3);
                                                           // Console.WriteLine(data4);
                                                           // Console.WriteLine(data4.Day); // Dia do mês
                                                           // Console.WriteLine(data4.Month); // Mês do ano
                                                           // Console.WriteLine(data4.Year); // Ano
                                                           // Console.WriteLine(data4.Hour); // Hora
                                                           // Console.WriteLine(data4.Minute); // Minuto
                                                           // Console.WriteLine(data4.Second); // Segundo
                                                           // Console.WriteLine(data4.DayOfWeek); // Dia da semana
                                                           // Console.WriteLine(data4.DayOfYear); // Dia do ano
        // Console.WriteLine(data4.AddDays(5)); // Adiciona 5 dias
        // Console.WriteLine(data4.AddMonths(2)); // Adiciona 2 meses
        // Console.WriteLine(data4.AddMonths(-2)); // Subtrai 2 meses
        // Console.WriteLine(data4.AddYears(1)); // Adiciona 1 ano

        Console.WriteLine(data4.ToLongDateString()); // Formato longo da data. Resultado: "sábado, 15 de agosto de 2020"
        Console.WriteLine(data4.ToShortDateString()); // Formato curto da data. Resultado: "15/08/2020"
        Console.WriteLine(data4.ToLongTimeString()); // Formato longo da hora. Resultado: "17:30:00"
        Console.WriteLine(data4.ToShortTimeString()); // Formato curto da hora. Resultado: "17:30"
        
    }
}
