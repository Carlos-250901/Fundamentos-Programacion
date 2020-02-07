using System;

namespace Desafio_05_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //------Entradas--------
            Console.WriteLine("Ingresa Votos partido 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa Votos partido 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa Votos Blanco");
            int Blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa Votos anulados");
            int Anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa Poblacion total");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa Porcentaje de adultos");
            int p = int.Parse(Console.ReadLine());

            bool A = a+b+Blancos+Anulados> n;
            bool B = a-b<(a+b+Blancos+Anulados)*(10/100.0);
            bool C = a+b+Blancos+Anulados <(n)*(30/100.0);
            //-------Salidas--------
            if ((A || B) && C)
            {
                Console.WriteLine("Las elecciones Se deben realizar nuevamente");
            }

            else if (a > b)
            {
                Console.WriteLine("Gana A");
            }
            else
            {
                Console.WriteLine("Gana B");
            }
            
         }
    }
}
