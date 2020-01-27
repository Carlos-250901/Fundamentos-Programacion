using System;

namespace Desafio0301
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese datos b,z,y");
            double b = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double t = Math.Sqrt(z*z+y*y);
          
            double a = Math.Asin(((Math.Sin(Math.PI/2))*y)/t)*(180/Math.PI);
            
            double d = 90-a-b;
            
            double ab = (a+b)*(Math.PI/180.0);
            double dr = d*(Math.PI/180.0);
            double x = ((z/Math.Sin(dr))*(Math.Sin(ab)))-y;
            Console.WriteLine("x es: " + x);
           }
    }
}
