using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_S5_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio1();
            Console.ReadKey();
        }

        static void ejercicio1()
        {
            double costoProducto, rebaja = 0, pagoFinal, subtotal, bonoExtra = 0;
            int tipoUsuario;

            // Mensaje inicial
            Console.WriteLine("===== SISTEMA DE DESCUENTOS =====");
            Console.Write("\nIngrese el costo unitario del artículo: ");
            costoProducto = double.Parse(Console.ReadLine());

            Console.WriteLine("\nSeleccione el tipo de descuento:\n[1] Estudiante\n[2] Empleado\n[3] Cliente frecuente");
            Console.Write("\nIngrese su opción: ");
            tipoUsuario = int.Parse(Console.ReadLine());

            // Validaciones anidadas
            if (costoProducto >= 0)
            {
                if (tipoUsuario <= 3 && tipoUsuario > 0)
                {
                    if (tipoUsuario == 1)
                    {
                        rebaja = costoProducto * 0.10;
                    }
                    else if (tipoUsuario == 2)
                    {
                        rebaja = costoProducto * 0.15;
                    }
                    else
                    {
                        rebaja = costoProducto * 0.20;
                    }
                }
                else
                {
                    Console.WriteLine("\nERROR: Tipo de descuento inválido.");
                }

                subtotal = costoProducto - rebaja;

                if (costoProducto > 500)
                    bonoExtra = subtotal * 0.05;

                pagoFinal = subtotal - bonoExtra;

                Console.WriteLine($"\nTotal a pagar luego del descuento: {pagoFinal:F2}");
            }
            else
            {
                Console.WriteLine("\nERROR: El costo ingresado no es válido.");
            }
        }
    }
}