using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido por favor indicanos tu nombre");
        string name = Console.ReadLine();
        Console.WriteLine($"{name}, presiona 1 para sumar o 2 para restar");
        int decision = int.Parse( Console.ReadLine() );
        if (decision == 1)
        {
            suma();
        }
        else resta();
    }
    // programa de metodo if y sobrecarga de metodos y/o metodos ------------------------------------------------------------
    static void suma()
    {
        Console.WriteLine("Digite numero a sumar");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite su segundo numero a sumar");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"su suma es {num1 + num2}");
    }
    static void resta()
    {
        Console.WriteLine("DIGITE SU NUMERO PARA RESTAR");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("DIGITE SU NUMERO PARA RESTAR");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Su resta es {num1 - num2}");
    }
}