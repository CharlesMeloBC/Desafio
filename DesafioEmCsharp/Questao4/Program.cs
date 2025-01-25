using System;

namespace DesafioEmCsharp.Questao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal SP = 67836.43M, RJ = 36678.66M, MG = 29229.88M, ES = 27165.48M, Outros = 19849.53M;
            decimal total = SP + RJ + MG + ES + Outros;

            Console.WriteLine($"SP: {SP / total:P}");
            Console.WriteLine($"RJ: {RJ / total:P}");
            Console.WriteLine($"MG: {MG / total:P}");
            Console.WriteLine($"ES: {ES / total:P}");
            Console.WriteLine($"Outros: {Outros / total:P}");
        }
    }
}
