/*
1) Número positivo, negativo o cero:
Escribe un programa que lea un número entero y determine si es positivo, negativo o cero.

2) Par o impar:
Escribe un programa que lea un número entero y determine si es par o impar.

3) Mayor de dos números:
Escribe un programa que lea dos números enteros y determine cuál es mayor.

4) Mayor de tres números:
Escribe un programa que lea tres números enteros y determine cuál es el mayor.

5) Año bisiesto:
Escribe un programa que lea un año y determine si es bisiesto. Un año es bisiesto si es divisible por 4, pero no por 100, a menos 
que también sea divisible por 400.

6) Calificación:
Escribe un programa que lea una calificación numérica (0-100) y muestre una letra de calificación según la escala:
90-100: A
80-89: B
70-79: C
60-69: D
0-59: F

7) Edad para votar:
Escribe un programa que lea la edad de una persona y determine si puede votar (mayor o igual a 18 años).

8) Descuento en tienda:
Escribe un programa que lea el total de una compra y aplique un descuento del 10% si el total es mayor a $100.

9) Número divisible por 3 y 5:
Escribe un programa que lea un número entero y determine si es divisible por 3, por 5, por ambos o por ninguno.

10) Operación matemática básica:
Escribe un programa que lea dos números y un operador (+, -, *, /) y realice la operación correspondiente, mostrando el resultado.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejercicios Condicional If Bienvenido");
        Console.WriteLine("Digita el numero que quiere evaluar");
        int numero = int.Parse(Console.ReadLine());
        if (numero < 0) Console.WriteLine("Su numero es negativo");
        else if (numero > 0) Console.WriteLine("su numero es positivo");
        else Console.WriteLine("Su numero es 0");


        Console.WriteLine("Numero Par o Impar");
        Console.WriteLine("Digita numero a evaluar si es par o impar");
        int numeroPar = int.Parse(Console.ReadLine());
        int respuesta = numeroPar % 2;
        if (respuesta == 0) Console.WriteLine("Es par");
        else Console.WriteLine("Es impar");


        Console.WriteLine("Digita dos numeros así vemos cual es mayor");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        if (num1 > num2) Console.WriteLine($"Numero {num1} es mayor");
        else if (num1 == num2) Console.WriteLine("Numeros son iguales");
        else Console.WriteLine("El numero " + " " + num2 + " " + "es mayor");


        Console.WriteLine("Digita 3 numeros");
        int numero1 = int.Parse(Console.ReadLine());
        int numero2 = int.Parse(Console.ReadLine());
        int numero3 = int.Parse(Console.ReadLine());
        if (numero1 > numero2 && num1 > numero3) Console.WriteLine(numero1 + " " + "es mayor");
        else if (numero2 > numero1 && numero2 > numero3) Console.WriteLine($"{numero2} es mayor");
        else Console.WriteLine( numero3 + " " + "es mayor");


        Console.WriteLine("Digita Año A Evaluar");
        int año = int.Parse(Console.ReadLine());
        int resuelve = año % 4;
        int resuelve1 = año % 400;
        int resuelve2 = año % 100;
        if ((resuelve == 0 && resuelve2 != 0) || resuelve1 == 0) Console.WriteLine("Su año es bisiesto");
        else Console.WriteLine("Su año no es bisiesto");


        Console.WriteLine("Digita tu nota dada de 0 a 100");
        int notaFinal = int.Parse(Console.ReadLine());
        if (notaFinal >= 90 && notaFinal <= 100) Console.WriteLine("su nota es A");
        else if (notaFinal >= 80 && notaFinal <= 89) Console.WriteLine("Su nota es B");
        else if (notaFinal >= 70 && notaFinal <= 79) Console.WriteLine("Su nota es C");
        else if (notaFinal >= 60 && notaFinal <= 69) Console.WriteLine("Su nota es D");
        else if (notaFinal >= 0 && notaFinal <= 59) Console.WriteLine("Su nota es F estudie mas!");
        else Console.WriteLine("Nota erronea");


        Console.WriteLine("Registre su edad por favor");
        int edad = int.Parse(Console.ReadLine());
        if (edad >= 18) Console.WriteLine("Bienvenido puede votar");
        else Console.WriteLine("No puede votar es menor de edad");


        Console.WriteLine("registre total de su compra por favor");
        int totalCompra = int.Parse(Console.ReadLine());
        if(totalCompra > 100)
            {
                double descuento = totalCompra * 0.1; 
                double totalConDescuento = totalCompra - descuento;
                Console.WriteLine("Su pago es de $" + totalConDescuento);
            }
        else Console.WriteLine("su compra no tiene descuento");



        Console.WriteLine("Ingrese un número entero:");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 3 == 0 && numero % 5 == 0)
        {
            Console.WriteLine("El número es divisible por 3 y por 5.");
        }
        else if (numero % 3 == 0)
        {
            Console.WriteLine("El número es divisible por 3 pero no por 5.");
        }
        else if (numero % 5 == 0)
        {
            Console.WriteLine("El número es divisible por 5 pero no por 3.");
        }
        else
        {
            Console.WriteLine("El número no es divisible ni por 3 ni por 5.");
        }



        Console.WriteLine("Ingrese el primer número:");
        double nume1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double nume2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el operador (+, -, *, /):");
        char operador = char.Parse(Console.ReadLine());

        double resultado = 0;

        if (operador == '+')
        {
            resultado = num1 + num2;
            Console.WriteLine($"El resultado de {num1} + {num2} es: {resultado}");
        }
        else if (operador == '-')
        {
            resultado = num1 - num2;
            Console.WriteLine($"El resultado de {num1} - {num2} es: {resultado}");
        }
        else if (operador == '*')
        {
            resultado = num1 * num2;
            Console.WriteLine($"El resultado de {num1} * {num2} es: {resultado}");
        }
        else if (operador == '/')
        {
            if (num2 != 0)
            {
                resultado = num1 / num2;
                Console.WriteLine($"El resultado de {num1} / {num2} es: {resultado}");
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
        }
        else
        {
            Console.WriteLine("Operador no válido.");
        }



    }


}