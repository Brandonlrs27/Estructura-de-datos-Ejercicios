using System;
using System.Threading;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Pida al usuario números separados por comas
             * Que te muestre las sumas y el promedio de estos numeros
             * Ej: 5,3,1 el programa deberá mostrar en pantalla 
             * la suma = 9 y el promedio = 3
             * El usuario puede ingresar la cantidad de numeros que quiera
             * Por lo menos 2 y estos deberán ser separados por comas
             */

            Console.WriteLine("Ingrese por lo menos dos numeros separados por comas");
            string k="",n = Console.ReadLine();
            float sum=0, promedio=0, divi=1, cantidad=1;
            foreach (char i in n)
            {
                Thread.Sleep(500);
                if (i == ',')
                {
                    divi++;
                    sum = sum + int.Parse(k);
                    cantidad++;
                    k = "";
                }
                else
                { 
                    k = k + i;
                }
 
            }
            int s = int.Parse(k);
            sum = sum + s;
            promedio = sum / divi;
            Console.WriteLine("La suma de los numeros es " + sum + " y el promedio es " + promedio + " de los " + cantidad + " números que ingreso");
            Console.ReadKey();
        }
    }
}
