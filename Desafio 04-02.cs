using System;

namespace Desafio_04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario");
            int tarifa = int.Parse(Console.ReadLine());
            if (tarifa < 877803 * 2)
            {
                Console.WriteLine("Paga tarifa A y su cuota moderadora es $3400");
            }
            else if (tarifa >= 877803 * 2 && tarifa < 877803 * 5)
            {
                Console.WriteLine("Paga tarifa B y su cuota moderadora es $13500");
            }
            else
            {
                Console.WriteLine("Paga tarifa C y su cuota moderadora es $35600");
            }
        }
     }
}
