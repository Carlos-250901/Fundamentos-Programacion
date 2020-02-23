using System;

namespace New_21
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int carta = 0, total = 0, n = 0, jugador = 0, max = 0;//variables, # de jugadres,contador y ganador
                string nombre = null, nombremax=null;
                Random aleatorio = new Random();
                string continuar = "s";   //respuestas

                Console.WriteLine("Ingrese Numero de jugadores minimo 2  y maximo 5");//analisis de # de jugadores
                n = int.Parse(Console.ReadLine());

                while (n < 2 || n > 5)
                {
                    Console.WriteLine("error minimo 2 jugadores o maximo 5 judaores");
                    n = int.Parse(Console.ReadLine());

                }
               
                
                while (jugador<n)
                {
                    Console.WriteLine("Escribre tu nombre");
                    nombre=Console.ReadLine();
                    jugador++;
                    Console.WriteLine("Bienvenido jugador" + nombre);
              
                    while (true)
                    {
                        
                        carta = aleatorio.Next(1, 11);
                        if (total > 21)
                        {
                            Console.WriteLine("Perdiste");
                            total = 0;
                            break;
                        }
                        else
                        {

                            total += carta;
                            if (total == 21)
                            {
                                Console.WriteLine("Ganaste");
                                break;
                            }
                            Console.WriteLine("Total: " + total);
                            Console.WriteLine("Desea continuar (s/n): ");
                            continuar = Console.ReadLine();
                            if (continuar == "n") break;
                            while (continuar != "s" && continuar != "n" && total < 21) {
                                Console.WriteLine("error solo s/n para esponder");
                                Console.WriteLine("Desea continuar (s/n): ");
                                continuar = Console.ReadLine();

                            }
                            if (continuar == "n") break;
                            if (total > max) max = total;
                            if (total > max) nombre = nombremax;
                        }


                    }
                    Console.WriteLine("Su total fue: " + total + "puntos");
                    Console.WriteLine("gracias por jugar");
                    

                }
                Console.WriteLine("Mayor Puntaje: " + max);
                Console.WriteLine("Ganador:"+ nombremax);
            }
        }
    }
} 