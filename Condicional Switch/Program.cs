internal class Program
{
    private static void Main(string[] args)
    {
    /*
    Escribe un programa que lea un número del 1 al 7 y muestre el día de la semana correspondiente 
    (1 para lunes, 2 para martes, etc.).
    */

        Console.WriteLine("Escribe un numero del 1 al 7 para darte dia de la semana");
        int diaSemana = int.Parse(Console.ReadLine());
        switch (diaSemana)
        {
            case 1:
                Console.WriteLine($"Según su día {diaSemana} corresponde al día Lunes");
                break;
            case 2:
                Console.WriteLine($"Según su día {diaSemana} corresponde al día Martes");
                break;
            case 3:
                Console.WriteLine($"Según su día {diaSemana} corresponde al día Miercoles");
                break;
            case 4:
                Console.WriteLine($"Según su día {diaSemana} corresponde al día Jueves");
                break;
            case 5:
                Console.WriteLine($"Según su día {diaSemana} corresponde al día Viernes");
                break;
            case 6:
                Console.WriteLine($"Según su día {diaSemana} corresponde al día Sabado");
                break;
            case 7:
                Console.WriteLine($"Según su día {diaSemana} corresponde al día Domingo");
                break;
            default: 
                Console.WriteLine($"día {diaSemana} no existe");
                break;


        }



    /*
    Mes del año:
    Escribe un programa que lea un número del 1 al 12 y muestre el nombre del mes correspondiente.
    */

        Console.WriteLine("Digita numero para saber el nombre del mes");
        int numeroMes = int.Parse(Console.ReadLine());
        switch (numeroMes)
        {
            case 1: Console.WriteLine("su mes esEnero");
                break;
            case 2: Console.WriteLine("su mes es Febrero");
                break;
            case 3: Console.WriteLine("su mes es Marzo");
                break;
            case 4: Console.WriteLine("su mes es Abril");
                break;
            case 5: Console.WriteLine("su mes es Mayo");
                break;
            case 6: Console.WriteLine("su mes es Junio");
                break;
            case 7: Console.WriteLine("su mes es Julio");
                break;
            case 8: Console.WriteLine("su mes es Agosto");
                break;
            case 9: Console.WriteLine("su mes es Septiembre");
                break;
            case 10: Console.Write("su mes es Octubre");
                break;
            case 11: Console.WriteLine("su mes es Noviembre");
                break;
            case 12: Console.WriteLine("su mes es Diciembre");
                break;
            default: Console.WriteLine("numero erroneo");
                break;
        }


    /*
    Calificación con letras:
    Escribe un programa que lea una letra (A, B, C, D, F) y muestre el rango numérico correspondiente a la calificación.
    */

        Console.WriteLine("escribe una letra A,B,C,D,F ");
        string letra = Console.ReadLine();
        switch (letra)
        {
            case "A":
                Console.WriteLine("Tienes un 5");
                break;
            case "B":
                Console.WriteLine("Tienes un 4");
                break;
            case "C":
                Console.WriteLine("Tienes un 3");
                break;
            case "D":
                Console.WriteLine("Tienes un 2");
                break;
            case "F": 
                Console.WriteLine("Tienes un 1");
                break;
            case "a":
                Console.WriteLine("Tienes un 5");
                break;
            case "b":
                Console.WriteLine("Tienes un 4");
                break;
            case "c":
                Console.WriteLine("Tienes un 3");
                break;
            case "d":
                Console.WriteLine("Tienes un 2");
                break;
            case "f":
                Console.WriteLine("Tienes un 1");
                break;
            default: Console.WriteLine("Numero equivocado");
                break;
        }


    /*
    Estaciones del año:
    Escribe un programa que lea un número del 1 al 4 y muestre la estación del año correspondiente
    (1 para primavera, 2 para verano, etc.).
    */

        Console.WriteLine("Escriba un numero del 1 al 4 para ver su estación");
        int estaciones = int.Parse(Console.ReadLine());
        switch (estaciones)
        {
            case 1:
                Console.WriteLine("Su estacion es Primavera");
                break;
            case 2:
                Console.WriteLine("Su estacion es Verano");
                break;
            case 3:
                Console.WriteLine("Su estacion es Otoño");
                break;
            case 4:
                Console.WriteLine("Su estacion es Invierno");
                break;
            default: Console.WriteLine("Estacion no existe");
                break;
        }


    /*
    Operaciones aritméticas:
    Escribe un programa que lea dos números y un operador 
    (+, -, *, /) y realice la operación correspondiente, mostrando el resultado.
    */

        Console.WriteLine("Desea sumar restar multiplicar o dividir, escribelo a continuacion en minusculas");
        string operacion = Console.ReadLine();
        Console.WriteLine($"Digita los dos numeros para realizar la {operacion}");
        int numero1 = int.Parse(Console.ReadLine());
        int numero2 = int.Parse(Console.ReadLine());
        switch (operacion)
        {
            case "suma":
                int respuesta = numero1 + numero2;
                Console.WriteLine($"su suma es {respuesta}");
                break;
            case "resta":
                Console.WriteLine("Su resta es" + " " + (numero1 - numero2));
                break;
            case "multiplicar":
                Console.WriteLine("su multiplicacion es " + " " + (numero1 * numero2));
                break;
            case "dividir":
                Console.WriteLine("su division es" + " " + (numero1 / numero2));
                break;
            default: Console.WriteLine("error de sintaxis operacion no validad");
                break;
        }



    /*
    Tipo de triángulo:
    Escribe un programa que lea un número del 1 al 3 y muestre el tipo de triángulo correspondiente 
    (1 para equilátero, 2 para isósceles, 3 para escaleno).
    */

        Console.WriteLine("Escribe un numero para saber tu triangulo del 1 al 3");
        int numTriangulo = int.Parse(Console.ReadLine());
        switch (numTriangulo)
        {
            case 1:
                Console.WriteLine("triangulo equilatero");
                break;
            case 2:
                Console.WriteLine("triangulo isosceles");
                break;
            case 3:
                Console.WriteLine("triangulo escaleno");
                break;
            default: Console.WriteLine("Error de sintaxis no encontrada");
                break;
        }



    /*
    Notas musicales:
    Escribe un programa que lea un número del 1 al 7 y muestre la nota musical correspondiente
    (1 para Do, 2 para Re, etc.).
    */

        Console.WriteLine("Escribe numero del 1 al 7 para decifrar la nota musical");
        int numNota = int.Parse(Console.ReadLine());
        switch (numNota)
        {
            case 1:
                Console.WriteLine("su nota es DO");
                break;
            case 2:
                Console.WriteLine("su nota es RE");
                break;
            case 3:
                Console.WriteLine("su nota es MI");
                break;
            case 4:
                Console.WriteLine("su nota es FA");
                break;
            case 5:
                Console.WriteLine("su nota es SO");
                break;
            case 6:
                Console.WriteLine("su nota es LA");
                break;
            case 7:
                Console.WriteLine("su nota es CI");
                break;
            default: Console.WriteLine("error no existe");
                break;

        }


    /*
    Menú de opciones:
    Escribe un programa que muestre un menú con 4 opciones (por ejemplo, 1 para agregar, 2 para editar, 
    3 para eliminar, 4 para salir) y ejecute la acción correspondiente según la opción seleccionada.
    */

        Console.WriteLine("escoge la opcion correcta: 1: agregar - 2: editar - 3: Eliminar - 4: Salir");
        int numeroOpcion = int.Parse(Console.ReadLine());
        switch (numeroOpcion)
        {
            case 1:
                Console.WriteLine("esta en el menu agregar bienvenido");
                break;
            case 2:
                Console.WriteLine("esta en el menu editar bienvenido");
                break;
            case 3:
                Console.WriteLine("esta en el menu eliminar bienvenido");
                break;
            case 4:
                Console.WriteLine("esta en el menu salir hasta la proxima");
                break;
            default: Console.WriteLine("Numero erroneo");
                break;
        }


    /*
    Conversión de monedas:
    Escribe un programa que lea un número del 1 al 4 y convierta una cantidad de dinero
    de una moneda a otra (por ejemplo, 1 para convertir de USD a EUR, 2 para convertir de EUR a GBP, etc.).
    */

        Console.WriteLine("escribe un numero del 1 al 4 para convertir moneda, el 1 euro dolar, el 2 peso dolar, el 3 sucres dolar y el 4 mexicanos dolar");
        int numConvertir = int.Parse(Console.ReadLine());
        switch (numConvertir)
        {
            case 1:
                Console.WriteLine("digita el euroa convertir");
                double euroD = int.Parse(Console.ReadLine());
                Console.WriteLine("su euro en dolar es" + " " + (euroD * 0.92));
                break;
            case 2:
                Console.WriteLine("digita el peso a convertir");
                double pesoD = int.Parse(Console.ReadLine());
                Console.WriteLine("su peso en dolar es" + " " + (pesoD * 3.900));
                break;
            case 3:
                Console.WriteLine("digita el euroa convertir");
                double sucreD = int.Parse(Console.ReadLine());
                Console.WriteLine("su euro en dolar es" + " " + (sucreD * 1.50));
                break;
            case 4:
                Console.WriteLine("digita el euroa convertir");
                double mexD = int.Parse(Console.ReadLine());
                Console.WriteLine("su euro en dolar es" + " " + (mexD * 1.500));
                break;
            default: Console.WriteLine("error no existe el cambio");
                break;
        }


    /*
    Categoría de edad:
    Escribe un programa que lea un número del 1 al 5 y muestre la categoría de edad 
    correspondiente (1 para niño, 2 para adolescente, 3 para adulto joven, 4 para adulto, 5 para anciano).
    */

        Console.WriteLine("escribe numero del 1 al 5 por favor");
        int numeroEdad = int.Parse(Console.ReadLine());
        switch (numeroEdad)
        {
            case 1:
                Console.WriteLine("Eres niño");
                break;
            case 2:
                Console.WriteLine("Eres adolescente");
                break;
            case 3:
                Console.WriteLine("Eres adulto joven");
                break;
            case 4:
                Console.WriteLine("Eres adulto");
                break;
            case 5:
                Console.WriteLine("Eres anciano");
                break;
            default: Console.WriteLine("No existe numero");
                break;
        }

    }
}