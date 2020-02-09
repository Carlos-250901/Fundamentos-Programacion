using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu salario");
            double salario = double.Parse(Console.ReadLine());//----entradas----
            Console.WriteLine("Ingresa tu tipo de contrato; 1.Dependiente 2.Independiente");
            int Tcontrato = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa nivel de riesgo de 1-5");
            int riesgo = int.Parse(Console.ReadLine());
            double minimo = 877803, Bcotizacion = salario * (40 / 100.0), prima = salario, SalarioAnual = 0, salarioreal = 0,
            pension = 0, arl = 0, eps = 0; 
            if (salario < minimo) salario = minimo;
            switch (Tcontrato)
            {
                case 1:
             arl= 0;
             eps = Bcotizacion * (4 / 100.0);
             pension= Bcotizacion*(4/100.0);
             salarioreal = salario - arl - eps - pension;
             SalarioAnual = salarioreal * 12 + prima;
                    Console.WriteLine("salario real: " + salarioreal);
                    Console.WriteLine("salario anual: " + SalarioAnual);
                    break;
                case 2:
                    switch (riesgo)
                    {
                        case 1:
                            arl = Bcotizacion * (0.522 / 100.0);
                            break;
                        case 2:
                            arl = Bcotizacion * (1.044 / 100.0);
                            break;
                        case 3:
                            arl = Bcotizacion * (2.436 / 100.0);
                            break;
                        case 4:
                            arl = Bcotizacion * (4.350 / 100.0);
                            break;
                        case 5:
                            arl = Bcotizacion * (6.960 / 100.0);
                            break;

                    }
                    eps = Bcotizacion * (12.5 / 100.0);
                    pension = Bcotizacion * (16 / 100.0);
                     salarioreal = salario-arl-eps-pension;
                     SalarioAnual = salarioreal * 12 + prima;
                    Console.WriteLine("salario real: "+salarioreal );
                    Console.WriteLine("salario anual: "+SalarioAnual);
                break;
            }

        }
    }
}
