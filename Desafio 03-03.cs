using System;

namespace Desafio0304
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese datos w,d,x");
            double w = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double dr = d * (Math.PI / 180);
            double z = (w / Math.Sin(Math.PI/2)) * (Math.Sin(dr));

            
            double catetoxy = Math.Sqrt(w*w-z*z) ;
            
            double y = catetoxy-x;
            Console.WriteLine("y es " + y);

        }
    }
}
