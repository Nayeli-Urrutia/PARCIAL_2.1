using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_2._1
{
    internal class Program
    {

        static void Main(string[] args)
        {


            Inventario inventario = new Inventario(5);

        
            inventario.AgregarProducto("Camiseta", 10);
            inventario.AgregarProducto("Pantalón", 5);
            inventario.AgregarProducto("Zapatos", 8);

            // Acceder a la cantidad de productos utilizando el indexador
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("**************************************************");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Cantidad de productos en el inventario:");
            Console.ResetColor();
            Console.WriteLine($"- Camisetas: {inventario["Camiseta"]}");
            Console.WriteLine($"- Pantalones: {inventario["Pantalón"]}");
            Console.WriteLine($"- Zapatos: {inventario["Zapatos"]}");
            

            // Modificar la cantidad de productos utilizando el indexador
            inventario["Camiseta"] = 10;
            inventario["Pantalón"] =  5;



            // Acceder a la cantidad total de productos utilizando la propiedad
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Cantidad total de productos en el inventario: {inventario.CantidadTotal}");
            Console.ResetColor();
           
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("**************************************************");
            Console.ResetColor();


            Console.ReadKey();
        }
    }
        
 }

        
    

