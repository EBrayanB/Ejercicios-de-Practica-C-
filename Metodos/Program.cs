internal class Program
{
    private static void Main(string[] args)
    {
        sumaNumeros();
        restaNumeros();
        multiplicacionNumeros();
        divisionNumeros();

        //metodos return

        Console.WriteLine(adicionNumeros());
        Console.WriteLine(nombreUsuario());
        Console.WriteLine(usuarioDivision());
    }
    // Metodos sin return
    //_______________________________________________________________________________________________________________________
    static void sumaNumeros()
    {
        Console.WriteLine("Usuario digite primer numero a sumar");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite su segundo numero para sumar");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Su suma es {num1 + num2}");
    }

    static void restaNumeros()
    {
        Console.WriteLine("Digite primer numero para restar");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digita segundo numero para restar");
        int num2 = int.Parse(Console.ReadLine());
        int resultado = num1 - num2;
        Console.WriteLine("Su resultado es " + resultado);
    }

    static void multiplicacionNumeros()
    {
        Console.WriteLine("Digite numero uno para multiplicar");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite su segundo numero a multiplicar");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Su multiplicacion es" + (num1*num2));
    }

    static void divisionNumeros()
    {
        Console.WriteLine("Digite un numero para dividir");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite su segundo numero a dividir");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Su division es {num1/num2}");
    }

    //___________________________________________________________________________________________________________________________
    //Metodos con return

    static int adicionNumeros()
    {
        Console.WriteLine("Usuario digite numero a sumar");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digita segundo numero a sumar");
        int num2 = int.Parse(Console.ReadLine());
        int resultado = num1 + num2;
        return resultado;
    }

    static string nombreUsuario()
    {
        Console.WriteLine("Usuario por favor digite su nombre");
        string nombre = Console.ReadLine();
        return nombre;
    }

    static double usuarioDivision()
    {
        Console.WriteLine("Porfavor que numero quieres dividir?");
        double num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digita segundo numero");
        double num2 = int.Parse(Console.ReadLine());
        double resultado = num1 / num2;
        return resultado;
    }


}