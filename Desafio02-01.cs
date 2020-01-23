using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        //ingreso de datos
        Console.WriteLine("Ingrese variables y y z");
        double y = double.Parse(Console.ReadLine());

        double z = double.Parse(Console.ReadLine());

        //formulas de t,a,c
        double t = Math.Sqrt(y * y + z * z);
        Console.WriteLine("t es");
        Console.WriteLine(t);
        

        double c = Math.Acos(y / t)*(180.0 / Math.PI);
       
        Console.WriteLine("c es");
        
        Console.WriteLine(c);
        double a = Math.Acos( z / t)*(180.0 / Math.PI);
       
        Console.WriteLine("a es");
        Console.WriteLine(a);
    }

}
