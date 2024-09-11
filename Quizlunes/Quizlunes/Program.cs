

public class Program
{
    private static void Main(string[] args)
    {

        double num1, num2, num3;

        Console.WriteLine("Ingrese el primer numero");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        num2 = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Ingrese el tercer numero");
        num3 = Convert.ToDouble(Console.ReadLine());

        if (((num1 > num2) && (num1 > num3)))
        {
            if (num2 > num3)
            {
                Console.Write("Numero 1 es el mayor, numero 2 es el intermedio y número 3 es el menor.");
            }
            else
            {
                Console.Write("Numero 1  es el mayor, numero 3 es el intermedio y numero 2 es el menor");
            }
        }
        else if ((num2 > num3) && (num2 > num1))
        {
            if ((num3 > num1))
            {
                Console.Write("Numero 2 es el mayor, numero 3 es el intermedio y número 1 es el menor.");
            }
            else
            {
                Console.Write("Numero 2 es el mayor, numero 1 es el intrermedio y el numero 3 es el menor");

            }

        }
        else if ((num3 > num1) && (num3 > num2))
        {
            if ((num1 > num3))
            {
                Console.Write("Numero 3 es el mayor, numero 1 es el intermedio y numero 2 es el menor");
            }
            else
            {
                Console.Write("Numero 3 es el mayor, numero 2 es el intermedio y numero 1 es el menor");
            }
        }


    }
}