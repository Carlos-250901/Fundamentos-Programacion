using System;

namespace Desafio_04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario");
            int tarifa = int.Parse(Console.ReadLine());
            if (tarifa < 877803*2)
            {
                Console.WriteLine("Paga tarifa A");
            }
            else if (tarifa >= 877803 * 2 && tarifa < 877803 * 4)
            {
                Console.WriteLine("Paga tarifa B");
            }
            else
            {
                Console.WriteLine("Paga tarifa C");
            }
         
        }
    }
}
