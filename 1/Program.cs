using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nochmal;
            do
            {
                int auswahl;
                Console.WriteLine("Auswahlmenü:");
                Console.WriteLine("1:Summe der ganzen Zahlen von a bis b.");
                Console.WriteLine("2:Verflixte 7.");
                Console.WriteLine("3:°C in °F umrechnen.");
                auswahl = Convert.ToInt32(Console.ReadLine());

                if (auswahl == 1)
                {
                    int a, b, sum = 0;
                    Console.WriteLine("Summe der ganzen Zahlen von a bis b berechnen:");
                    Console.WriteLine("a:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("b:");
                    b = Convert.ToInt32(Console.ReadLine());
                    for (int i = a; i <= b; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine("Die Summe der ganzen Zahlen von {0} bis {1} ergibt {2}", a, b, sum);
                }
                else if (auswahl == 2)
                {
                    int end;
                    string end1;
                    Console.WriteLine("Obere Zahl angeben:");
                    end = Convert.ToInt32(Console.ReadLine());
                    end1 = Console.ReadLine();
                    for (int e = 1; e <= end; e++)
                    {
                        if (e % 7 == 0)
                        {
                            Console.WriteLine(e);
                            Console.WriteLine("--{0}--", e);
                        }
                        else
                        {
                            Console.WriteLine(e);
                        }
                    }

                }
                else if (auswahl == 3)
                {
                    double t, C, F;
                    Console.WriteLine("Temperatur eingeben:");
                    t = Convert.ToInt32(Console.ReadLine());
                    F = Math.Round(32 + t * 1.8,1);
                    Console.WriteLine("{0}°C entsprechen {1}°F", t, F);
                    C = Math.Round((t - 32) / 1.8);
                    Console.WriteLine("{0}°F entsprechen {1}°C", t, C);
                }
                Console.WriteLine("Neue Auswahl?(j/n)");
                nochmal = Console.ReadLine();
            } while (nochmal == "j");
            Console.ReadKey();
        }
    }
}
