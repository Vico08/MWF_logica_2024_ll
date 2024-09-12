public class Program
{
    private static void Main(string[] args)
    {
        double num1, num2, num3;

        Console.WriteLine("INGRESE EL PRIMER NUMERO");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("INGRESE EL SEGUNDO NUMERO");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("INGRESE EL TERCER NUMERO");
        num3 = Convert.ToDouble(Console.ReadLine());

        if
            (num1 > num2) && (num2 > num3)

        { Console.WriteLine("NUMERO 1 ES EL MAYOR, EL NUMERO 2 ES EL INTERMEDIO Y EL NUMEOR 3 ES EL MENOR");

         }

    }
}