using System;
//Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas,
//el vendedor desea saber cuánto dinero obtendrá por concepto de comisiones por
//las tres ventas que realiza en el mes y el total que recibirá en el mes tomando en
//cuenta su sueldo base y comisiones.
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sBase, venta1, venta2, venta3, comision1, comision2, comision3, tComisiones, tSueldo;
            string nomVendedor;

            Console.Write(" Ingrese el nombre del vendedor : ");
            nomVendedor = Console.ReadLine();

            Console.Write("\n Ingrese el sueldo base : ");
            sBase = Double.Parse(Console.ReadLine());

            Console.Write("\n Ingrese valor de primera venta : ");
            venta1 = Double.Parse(Console.ReadLine());
            comision1 = venta1 * 0.10;

            Console.Write("\n Ingrese valor de segunda venta : ");
            venta2 = Double.Parse(Console.ReadLine());
            comision2 = venta2 * 0.10;

            Console.Write("\n Ingrese valor de tercera venta : ");
            venta3 = Double.Parse(Console.ReadLine());
            comision3 = venta3 * 0.10;

            tComisiones = comision1 + comision2 + comision3;
            tSueldo = sBase + tComisiones;

            Console.WriteLine("\n El total de comisiones es de : {0:C2}", tComisiones);
            Console.WriteLine(" El sueldo base mas las comisiones es de {0:C2}", tSueldo);
        }
    }
}

