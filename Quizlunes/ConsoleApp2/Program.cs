using System.ComponentModel.Design;

internal class Program
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

        if (((num1 > num2) & (num1 > num3)))
        {
            if (num2 > num3)
            {
                Console.Write("numero 1 es el mayor, numero 2 es el intermedio,  el numero 3 es el menor");
            }
            else
            {
                Console.Write("numero 1 es el mayor, numero 3 es el intermedio, numero 2 es el menor");
            }
        }
        else if ((num2 > num1) && (num2 > num3))
         {
             if ((num1 > num3))
                    {
                        Console.Write("numero 2 es el mayor, numero 1 es el intermedio,  el numero 3 es el menor");
                    }
                    else
                    {
                        Console.Write("numero 2 es el mayor, numero 3 es el intermedio, numero 1 es el menor");
                }
            }

            else if ((num3 > num1) && (num3 > num2))
                    {
                        if ((num1 > num2))
                        {
                            Console.Write("numero 3 es el mayor, numero 1 es el intermedio,  el numero 2 es el menor");
                        }
                        else
                        {
                            Console.Write("numero 3 es el mayor, numero 2 es el intermedio, numero 1 es el menor");
                        }

                    }
                }
}


