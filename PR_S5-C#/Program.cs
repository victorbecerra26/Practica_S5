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
            ejercicio2();
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
        static void ejercicio2()
        {
            int calificacion;
            string respuesta, nota = "";

            Console.Write("Ingrese una calificación entre 0 y 20: ");
            calificacion = int.Parse(Console.ReadLine());

            if (calificacion >= 0 && calificacion <= 20)
            {
                switch (calificacion)
                {
                    case int valor when (valor >= 0 && valor <= 10):
                        respuesta = "Desaprobado";
                        break;
                    case int valor when (valor >= 11 && valor <= 13):
                        respuesta = "Regular";
                        break;
                    case int valor when (valor >= 14 && valor <= 17):
                        respuesta = "Bueno";
                        break;
                    default:
                        respuesta = "Excelente";
                        break;
                }

                if (calificacion >= 14 && calificacion % 2 == 0)
                    nota = "Buen desempeño con nota par";

                if (calificacion < 11 || calificacion % 2 != 0)
                    nota = "Requiere mejorar";

                Console.WriteLine($"Su clasificación es: {respuesta} + {nota}");
                Console.WriteLine($"\nRaíz cuadrada de la calificación: {Math.Sqrt(calificacion):F1}");
                Console.WriteLine("Calificación elevada al cubo: " + Math.Pow(calificacion, 3));
            }
            else
            {
                Console.WriteLine("\nERROR: Calificación fuera del rango permitido.");
            }
        }
    }
}