using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;

internal class Program
{
    private static void Main(string[] args)
    {


        /*Suma de N números:
        Escribe un programa que lea un número N y calcule la suma de los primeros N números naturales(1 + 2 + ... +N).*/


        /*Console.WriteLine("introduce un numero por favor");
        int numeroIntroducido = int.Parse(Console.ReadLine());
        int contador = 0;
        int resultadoSuma = 0;
        while (numeroIntroducido != contador)
        {
            contador +=1;
            Console.WriteLine($"su suma es {resultadoSuma} mas {contador}");
            resultadoSuma = resultadoSuma + contador;
            Console.WriteLine($"el resultado es {resultadoSuma}");
        }*/



        /*Factorial de un número:
        Escribe un programa que lea un número y calcule su factorial utilizando un bucle while.*/


        /*Console.WriteLine("Escriba un numero por favor para su factorizacion");
        int numeroFactor = int.Parse(Console.ReadLine());
        int contadorFactor = 1;
        int resultado = 1;
        while (contadorFactor <= numeroFactor)
        {
            resultado *= contadorFactor;
            contadorFactor++;
            Console.WriteLine($"su resultado fue {resultado}");

        }



    /*Números pares:
    Escribe un programa que lea un número N y muestre todos los números pares desde 1 hasta N.*/


        /*Console.WriteLine("Digita un numero por favor");
        int numeroPar = int.Parse(Console.ReadLine());
        int contadorPar = 1;
        while (contadorPar <= numeroPar)
        {
            int resultado = contadorPar % 2;
            if (resultado == 0)
            {
                Console.WriteLine(contadorPar);
                contadorPar++;
            }
            else contadorPar++;
        }



    /*Serie de Fibonacci:
    Escribe un programa que lea un número N y muestre los primeros N números de la serie de Fibonacci.
        

        Console.WriteLine("Escribe un numero");
        int numeroFibonacci = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int contadorFibo = 0;
        while (contadorFibo < numeroFibonacci)
        {
            Console.WriteLine(a);
            int temporal  = a;
            a = b;
            b = temporal + b;
            contadorFibo++;

        }*/



    /*Adivinar un número:
    Escribe un programa que genere un número aleatorio entre 1 y 100.El usuario debe adivinar el número.
    El programa debe indicar si el número ingresado es mayor o menor que el número generado hasta que el usuario 
    adivine el número correcto.


                Random num = new Random();
                int numero = num.Next(1,100);
                Console.WriteLine("introduce un numero para iniciar");
                int numeroUsuario = int.Parse(Console.ReadLine());
                int contador = 1;
                while (numeroUsuario != numero)
                {
                    if (numeroUsuario < numero)
                    {
                        Console.WriteLine("numero es mayor vuelve a intentar");
                        numeroUsuario = int.Parse(Console.ReadLine());
                    }
                    else if (numeroUsuario > numero){

                        Console.WriteLine("numero es menor vuelve a intentar");
                        numeroUsuario = int.Parse(Console.ReadLine());
                    }
                    contador++;

                }
                Console.WriteLine($"felicidades el numero era {numero} y necesito de {contador} intentos");
                */



    /*Promedio de números:
    Escribe un programa que lea una serie de números hasta que el usuario ingrese un número negativo.
    El programa debe calcular y mostrar el promedio de los números ingresados(excluyendo el número negativo).


        Console.WriteLine("Digita tus numeros para poder hacerte el promedio saldra cuando ingreses un numero negativo");
        int numPromedio = int.Parse(Console.ReadLine());
        int contador = 0;
        int suma = 0;
        while (numPromedio > 0)
        {
            suma += numPromedio;
            contador++;
            numPromedio = int.Parse(Console.ReadLine());
        }
        if (contador > 0)
        {
            int resultado = suma / contador;
            Console.WriteLine($"su promedio es {resultado}");
        }
        else Console.WriteLine("no se ingresaron numeros positivos");/*



/*Contar dígitos:
Escribe un programa que lea un número entero y cuente cuántos dígitos tiene.*/



/*Inversión de un número:
Escribe un programa que lea un número entero y lo invierta(por ejemplo, si el número es 1234, 
el resultado debe ser 4321).*/

/*Suma de dígitos:
Escribe un programa que lea un número entero y calcule la suma de sus dígitos.*/

/*Múltiplos de un número:
Escribe un programa que lea dos números N y M, y muestre los primeros N múltiplos de M.*/
    }
}