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
        Console.WriteLine("Ingrese variables t y a");
        double t = double.Parse(Console.ReadLine());

        double a = double.Parse(Console.ReadLine());

        //formulas de y,z,c
        double c = (a-90.0)*Math.PI/180.0;
        Console.WriteLine("c es");
        Console.WriteLine(c);
        double z = (Math.Cos(a) * t)*(Math.PI/180.0);
        Console.WriteLine("z es");
        Console.WriteLine(z);
        double y = (Math.Sin(c) * t) * (Math.PI / 180.0);
        Console.WriteLine("y es");
        Console.WriteLine(y);


    }

}
