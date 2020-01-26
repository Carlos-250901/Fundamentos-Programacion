using System;

namespace Tarea2
{
    class Desafio0
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese datos w,t,c");
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double cr = c*(Math.PI/180);
            
            double e = 180.0-cr;
            double d = Math.Asin((t*Math.Sin(e))/w);
            double x = (w/Math.Sin(e))*Math.Sin(d);

;            Console.WriteLine("x es " + x);
        }
    }
}
