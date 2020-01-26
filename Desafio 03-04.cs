using System;

namespace desafio_04
{
    class Program
    {
        static void Main(string[] args)
        {

            
                Console.WriteLine("Ingrese datos w,t,c");
                double w = double.Parse(Console.ReadLine());
                double t = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
            double cr = c*(Math.PI/180.0);
            Console.WriteLine(cr);
            double e = Math.PI-cr;
            double d = Math.Asin((t * Math.Sin(e)) / (w));
            
            double b = Math.PI-d-e ;
           
                double x = (w / Math.Sin(e)) * Math.Sin(b);

                ; Console.WriteLine("x es " + x);
            }
        }
    }

