using System;

namespace DesafioEmCsharp.Questao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string para inverter: ");
            string input = Console.ReadLine();
            string inverted = InverterString(input);

            Console.WriteLine($"String invertida: {inverted}");
        }

        static string InverterString(string str)
        {
            char[] invertida = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                invertida[i] = str[str.Length - 1 - i];
            }

            return new string(invertida);
        }
    }
}
