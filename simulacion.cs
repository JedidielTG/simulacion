using System;


// Instrucciones del profesor 
// Cálculo de Pi: El método de Montecarlo puede usarse para estimar el valor de Pi lanzando puntos aleatorios
// dentro de un cuadrado y contando cuántos de esos puntos caen dentro de un círculo inscrito en el cuadrado. 
// Cuanto más puntos se lancen, más precisa será la estimación de Pi.
// Esta teoría debe ser generada en el lenguaje de su gusto, esta debe ser subida a GIthub, con su respectivo Readme de presentación con nombre, grado y grupo.


// Se muestra un codigo donde se lleva a la paractica el metodo montecarlo para deterinar pi.

namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se creo una instancia del generador de números aleatorios
            Random random = new Random();

            // Número total de puntos que se generarán durante la prueba
            int puntostotales = 10000007;

            // Contador para los puntos que esten dentro del círculo 
            int puntosencirculo = 0;

            // inicio con generar los puntos aleatorios y verificar si están dentro del círculo 
            // para ello se desarrollo el siguiente for.
            for (int i = 0; i < puntostotales; i++)
            {
                // Esta seccion genera coordenadas x e y, las cuales son aleatorias entre 0 y 1
                double x = random.NextDouble(); 
                double y = random.NextDouble();

                // Calcula la distancia del punto al origen o en otras palabras el margen de punto (0,0)
                // para esto use la funcion math.sqr la cual lleva el valor de x e y al su raiz.
                double distancia = Math.Sqrt(x * x + y * y);

                // una vez obtenido el resultado de mi variable distancia esta me ayuda a verificar si el punto está dentro del círculo.
                // creando la condicional y modificando mi contador.
                if (distancia <= 1)
                {
                    puntosencirculo++;
                }
            }

            // Calcula la estimación de π utilizando la proporción de puntos dentro del círculo
            // El siguiente punto del codigo, me baso en realizar la operacion para determinar π la cual tomo 
            // como informacion la superficie de un circulo que es πR CUADRADA entre la superficie del cuadrado teniendo esta como 4R CUADRADA
            //  para esto se elimina R CUADRADRA quedando π/4, a este procedimiento debemos despejar nuestras ecuaciones las cuales me llevan a
            // crear el siguiente codigo >>>
            double Pi = 4.0 * puntosencirculo / puntostotales;
            // mi varibale pi es igual a 4 por la cantidad de puntos que calleron en mi circulo entre las catidad de veces que genere.

            // Muestra el valor estimado de π, vazandoce en el valor 
            Console.WriteLine($"Estimacion del valor de π: {Pi}");
        }
    }
}