public class Program
{
    private static void Main(string[] args)
    {
        

        double x1, x2, y1, y2, d;
        //x1 = 4;
        //x2 = 5;
        //y1 = 5.2;
        //y2 = 15.58;
        //1 forma de inicializar

        //inicializar variables pidiendolas por pantalla 
        Console.WriteLine("Ingrese la primer coordenaada x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda coordenaada y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera coordenaada x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la cuarta coordenaada y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        double x = (x2 - x1) * (x2 - x1);
        double y = (y2 - y1) * (y2 - y1);
        double suma = x + y;
        
        d = Math.Sqrt(suma);

        Console.Write(suma);



    }
}