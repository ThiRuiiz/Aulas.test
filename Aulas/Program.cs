using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello guys");

        Console.WriteLine("Quanto é 5x3");
        int x = 5;
        int y = 3 * x;
        Console.WriteLine(y);

        string frase = Console.ReadLine();

        Console.WriteLine("Olá, Bom dia: " + frase);

        Console.WriteLine("ESCREVENDO JUNTO E SEPARANDO");
        string s = Console.ReadLine();
        string[] v = s.Split(' ');
        string a = v[0];
        string b = v[1];
        string c = v[2];
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        Console.WriteLine("TRANSFORMANDO TEXTO EM NUMERO INTEIRO COM CONVERSÃO");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Você digitou: " + n1);

        char ch = char.Parse(Console.ReadLine());
        Console.WriteLine(ch);
    }
}