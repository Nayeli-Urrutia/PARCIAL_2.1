using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_2._1
{
    internal class Inventario
    {
        private string[] productos;
        private int[] cantidades;

        // Indexador para acceder a la cantidad de un producto por su nombre
        public int this[string producto]
        {
            get
            {
                int index = Array.IndexOf(productos, producto);
                if (index != -1)
                {
                    return cantidades[index];
                }
                else
                {
                    return -1; 
                }
            }
            set
            {
                int index = Array.IndexOf(productos, producto);
                if (index != -1)
                {
                    cantidades[index] = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"El producto '{producto}' no está en el inventario.");
                    Console.ResetColor();
                }
            }
        }

        // Propiedad para obtener la cantidad total de productos en el inventario
        public int CantidadTotal
        {
            get
            {
                int total = 0;
                foreach (int cantidad in cantidades)
                {
                    total += cantidad;
                }
                return total;
            }
        }

        // Constructor
        public Inventario(int tamaño)
        {
            productos = new string[tamaño];
            cantidades = new int[tamaño];
        }

        // Método para agregar un producto al inventario
        public void AgregarProducto(string producto, int cantidad)
        {
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i] == null)
                {
                    productos[i] = producto;
                    cantidades[i] = cantidad;
                    return;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El inventario está lleno, no se puede agregar más productos.");
            Console.ResetColor();
        }
    }
}
