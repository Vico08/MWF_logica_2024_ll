public class Program
{
    private static void Main(string[] args)
    {
        const decimal precio_kilo = 5000; //declaracion constante

        Console.Write("Cuantos kilos de manzana va a llevar");
        decimal kilo_manzana = Convert.ToDecimal(Console.ReadLine());

        decimal descuento, precioBruto, precioNeto, precioDescuento;
        kilo_manzana = 5000;

            if ( kilo_manzana >= 0 && kilo_manzana <= 2)
        {
            descuento = 0;
        }
            else if (kilo_manzana > 2 && kilo_manzana <= 5)
        {
            descuento = 10;
        }
        else if (kilo_manzana > 5 && kilo_manzana <= 10)
        {
            descuento = 15;
        }
        else
        {
            descuento = 20;
        }

        precioBruto = precio_kilo * kilo_manzana;

        precioDescuento = precioBruto * (descuento / 100);

        precioNeto = precioBruto - precioDescuento;

        Console.Write("Precio bruto:" precioBruto," ");



    }
}

