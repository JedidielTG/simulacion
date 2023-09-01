using System;

namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se creo una instancia del generador de números aleatorios
            Random random = new Random();

            // Número total de puntos que se generarán
            int puntostotales = 10000007;

            // Contador para los puntos dentro del círculo
            int puntosencirculo = 0;

            // Generar los puntos aleatorios y verificar si están dentro del círculo
            for (int i = 0; i < puntostotales; i++)
            {
                // Genera coordenadas x e y aleatorias entre 0 y 1
                double x = random.NextDouble();
                double y = random.NextDouble();

                // Calcula la distancia del punto al origen (0,0)
                double distancia = Math.Sqrt(x * x + y * y);

                // Verificar si el punto está dentro del círculo unitario (radio 1)
                if (distancia <= 1)
                {
                    puntosencirculo++;
                }
            }

            // Calcula la estimación de π utilizando la proporción de puntos dentro del círculo
            double Pi = 4.0 * puntosencirculo / puntostotales;

            // Mostrar el valor estimado de π, vazandome en el valor 
            Console.WriteLine($"Estimacion del valor de π: {Pi}");
        }
    }
}