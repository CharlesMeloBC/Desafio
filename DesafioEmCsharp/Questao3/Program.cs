using System;
using System.Text.Json;

namespace DesafioEmCsharp.Questao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("faturamento.json");
            var faturamento = JsonSerializer.Deserialize<decimal[]>(json);

            var diasComFaturamento = faturamento.Where(v => v > 0).ToArray();
            var menorValor = diasComFaturamento.Min();
            var maiorValor = diasComFaturamento.Max();
            var mediaMensal = diasComFaturamento.Average();
            var diasAcimaDaMedia = diasComFaturamento.Count(v => v > mediaMensal);

            Console.WriteLine($"Menor valor: {menorValor:C}");
            Console.WriteLine($"Maior valor: {maiorValor:C}");
            Console.WriteLine($"Dias acima da média mensal: {diasAcimaDaMedia}");
        }

    }
}
