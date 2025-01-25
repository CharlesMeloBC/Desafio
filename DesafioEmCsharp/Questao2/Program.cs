using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe um número para verificar na sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());

        if (IsFibonacci(numero))
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool IsFibonacci(int n)
    {
        int a = 0, b = 1, temp;

        while (a <= n)
        {
            if (a == n)
                return true;
            temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }
}
