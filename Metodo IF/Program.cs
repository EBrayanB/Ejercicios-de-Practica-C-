using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Metodo IF Mayor de edad

        Console.WriteLine("Bienvenido este es un programa de ingreso para mayores de edad");
        Console.WriteLine("Por favor digite su nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Bienvenido {nombre}");
        Console.WriteLine("Cuantos años tienes?");
        int edad = int.Parse(Console.ReadLine());
        if (edad >= 18)
        {
            Console.WriteLine($"{nombre}, tienes, {edad} años, puedes pasar");
        }
        else Console.WriteLine("Lo siento no eres mayor de edad");

        _______________________________________________________________________________________*/

        /* Metodo IF de operaciones basicas

        Console.WriteLine("¿Bienvenido como te llamas?");
        string nombre = Console.ReadLine();
        Console.WriteLine($"{nombre} que operacion deseas realizar? suma, resta, division o multiplicación");
        string operacion = Console.ReadLine();
        if( operacion == "suma")
        {
            Console.WriteLine("Digite numero uno para sumar");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundo numero a sumar");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 + num2;
            Console.WriteLine($"Su resultado es {resultado}");

        }
        else if( operacion == "resta")
        {
            Console.WriteLine("Estas en el area de la operacion resta digita numero para restar");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Muy bien ahora digita tu segundo numero a restar");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 - num2;
            Console.WriteLine($"{nombre} el resultado de su resta es {resultado}");
        }
        else if( operacion == "division")
        {
            Console.WriteLine("Ingresaste a la operacion de division por favor digita tu numeroa dividir");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundo numero");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 / num2;
            Console.WriteLine($"{nombre} el resultado de su division es {resultado}");
        }
        else if (operacion == "multiplicacion")
        {
            Console.WriteLine($"{nombre} estas en la operacion de multiplicacion digita un numero para multiplicar");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{nombre} digita por favor segundo numero");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{nombre} su resultado es {num1 * num2}");
        }
        ______________________________________________________________________________________________________________*/
    }
}