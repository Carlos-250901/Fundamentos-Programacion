using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dado = 0, total = dado, i = 0;
            Random aleatorio = new Random();
            string continuar = "s";
            while (continuar == "s")
            {
              

                dado = aleatorio.Next(1, 13);
                total += dado;
                while (i == 3 && continuar=="s")
                {
                    dado = aleatorio.Next(1, 13);
                    
                    if (dado % 2 != 0)
                    {
                        Console.WriteLine("Perdiste");
                        total += dado;
                        continuar = null;
                    }
                    else
                    {
                        total += dado;
                        if (dado == 12)
                        {
                            if (dado == 10)
                            {
                                Console.WriteLine("Ganaste");
                                total += dado;
                                continuar = null;
                            }
                        }
                        if (total >= 100)
                        {
                            continuar = null;
                        }
                        else
                        {
                            Console.WriteLine("Total: " + total);
                            Console.WriteLine("Desea continuar (s/n): ");
                            continuar = Console.ReadLine();

                        }
                    }
                }
                
                
                i +=1;
                if (i == 3) continuar = null;
                if (total >= 100) continuar = null;
                
                else
                {
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("Desea continuar (s/n): ");
                    continuar = Console.ReadLine();

                }
                
            }
           Console.WriteLine("Su total fue " + total + "puntos");
                Console.WriteLine("gracias por jugar");

        }
        
            
    }   
}

