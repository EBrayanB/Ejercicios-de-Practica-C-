internal class Program
{
    private static void Main(string[] args)
    {
        sumaNumeros(2,3);
        sumaNumeros(1, 2, 3);
        sumaNumeros(1, 2, 3, 4);
        sumaNumeros(2,2,2,3);
        restaNumeros(2,2);
        restaNumeros(8, 2, 1);
        restaNumeros(1, 2, 3, 4); 
    }
    // Sobre carga de Metodos con Metodos sin Return -----------------------------------------------------------------------

    static void sumaNumeros(int num1, int num2)
    {
        int resultado = num1 + num2;
        Console.WriteLine("su suma es" + " " + resultado);
    }
    static void sumaNumeros(int num1, int num2, int num3)
    {
        int resultado = num1 + num2 + num3;
        Console.WriteLine($"Su suma es {resultado}");
    }
    static void sumaNumeros(int num1, int num2, int num3, int num4)
    {
        int resultado = num1 + num2 + num3 + num4;
        Console.WriteLine("su resultado es" + " " + resultado);
    }
    //-------------------------------------------------------------------------------------------------------------------------

    // Sobre carga de Metodos con Metodos con Return---------------------------------------------------------------------------

    static int restaNumeros(int num1, int num2)
    {
        int resultado = num1 - num2;
        Console.WriteLine($"su resta es {resultado}");
        return resultado;
    }
    static int restaNumeros(int num1, int num2, int num3)
    {
        int resultado = num1 - num2 - num3;
        Console.WriteLine($"su resta es {resultado}");
        return resultado;
    }
    static int restaNumeros(int num1,int num2,int num3,int num4)
    {
        int resultado = num1 - num2 - num3 - num4;
        Console.WriteLine("su resultado es " + " " + resultado);
        return resultado;
    }

    //------------------------------------------------------------------------------------------------------------------------
}