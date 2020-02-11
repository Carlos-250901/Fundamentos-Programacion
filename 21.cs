using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            int carta = 0;
            int total = 2;
            Random aleatorio = new Random();
            string continuar = "s";
            while (continuar == "s" && total <= 21)
            {

                carta = aleatorio.Next(1, 11);
                if (total > 21)
                {
                    Console.WriteLine("Perdiste");
                }
                else
                {
                    total += carta;
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("Desea continuar (s/n): ");
                    continuar = Console.ReadLine();

                }

            }
            if (total > 21)
            {
                Console.WriteLine("Perdiste");
            }
            if (total == 21)
            {
                Console.WriteLine("Ganaste");
            }
            Console.WriteLine("Su total fue: " + total + "puntos");
            Console.WriteLine("gracias por jugar");

        }
    }
}
