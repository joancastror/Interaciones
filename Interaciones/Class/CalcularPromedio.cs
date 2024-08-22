

using System.Drawing;
using System;

namespace Interaciones.Class
{
    public class CalcularPromedio
    {
        public void Calcular() 
        {
            int suma = 0;
            decimal promedio = 0;
            int cantidad = 0;
            int valor = 0;



            Console.WriteLine("digite la cantidad que desea calcular");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++) 
            {
                Console.WriteLine($"Digite el valor {i}:");
                valor = Convert.ToInt32(Console.ReadLine());
                //suma += valor;
                suma = suma + valor;


            }
            promedio = (suma / cantidad);
            Console.WriteLine($"la suma es: {suma} y el promedio es {promedio}");

        }

        public void CalcularNotas()
        {
            int aprobado = 0;
            int reprobado = 0;
            int cantidad = 0;
            int calificaciones = 0;

            Console.WriteLine("digite la cantidad que desea calcular: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine($"ingrese la calificacion {i}");
                calificaciones = Convert.ToInt32(Console.ReadLine());
                if (calificaciones >= 7)
                {
                    aprobado = aprobado + 1;
                    //aprobado++;
                }
                else
                {
                    reprobado = reprobado + 1;
                    //reprobado++;
                }
            }
            Console.WriteLine($"Aprobados: {aprobado} y reprobados: {reprobado} ");
        }

        public void CalcularPromedioWhile()
        {
            int suma = 0;
            decimal promedio = 0;
            int cantidad = 0;
            int valor = 0;
            int index = 1;

            Console.WriteLine("digite la cantidad que desea calcular: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            
            promedio = (suma / cantidad);
            Console.WriteLine($"la suma es: {suma} y el promedio es: {promedio}");
        }

        public void CalcularPerfiles()
        {
            try
            {
                int cantidad = 0;
                int index = 1;
                float largo = 0;
                int cantpiezas = 0;
                double minimo = 1.20;
                double maximo = 1.30;

                Console.WriteLine("Digite la cantidad de piezas que desea procesar: ");
                cantidad = Convert.ToInt32(Console.ReadLine());

                while (index <= cantidad)
                {
                    Console.WriteLine($"Digite el valor {index}: ");
                    largo = float.Parse(Console.ReadLine());

                    if (largo >= minimo && largo <= maximo)
                    {
                        cantpiezas++;
                    }

                    index++;
                }

                Console.WriteLine($"La cantidad de piezas evaluadas es: {cantidad} y la cantidad de piezas aptas es: {cantpiezas}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: El valor ingresado no es un número válido. Intente nuevamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
            }
            Console.ReadLine();
        }

        public void ProcesarTriangulos()
        {
            try
            {
                Console.WriteLine("Ingrese la cantidad de triángulos a procesar: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int contador = 1;
                int cantidadTriangulosSuperanArea = 0;

                while (contador <= n)
                {
                    Console.WriteLine($"Triángulo {contador}:");

                    Console.Write("Ingrese la base del triángulo: ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese la altura del triángulo: ");
                    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

                    double area = (baseTriangulo * alturaTriangulo) / 2;

                    Console.WriteLine($"Base: {baseTriangulo}, Altura: {alturaTriangulo}, Área: {area}");

                    if (area > 12)
                    {
                        cantidadTriangulosSuperanArea++;
                    }

                    contador++;
                }

                Console.WriteLine($"Cantidad de triángulos con área superior a 12 unidades cuadradas: {cantidadTriangulosSuperanArea}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: El valor ingresado no es un número válido. Intente nuevamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
            }

            Console.ReadLine();
        }
    }

}
}
