using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
class Desafio

{
    static void Main(string[] args)
    {
        //ingreso de datos
        Console.WriteLine("Ingrese variables c y z");
        double c = double.Parse(Console.ReadLine());

        double z = double.Parse(Console.ReadLine());

        //formulas de a,t,y
        
        double a = (180-90-c)*Math.PI/180;

        Console.WriteLine("a es");
        Console.WriteLine(a);

        double y = Math.Tan(a)*z;
        Console.WriteLine("y es");
        Console.WriteLine(y);
        double t = Math.Sqrt(y*y+z*z);
        Console.WriteLine("t es");
        Console.WriteLine(t);
    }
}