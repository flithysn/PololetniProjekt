using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektos
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string cely = "";
            double hodnota1 = 0;
            double hodnota2 = 0;
            double hodnota3 = 0;
            bool opakovani = true;

            while (opakovani)
            {
                Random random = new Random();
                int option = random.Next(1, 4);
                double value1 = Math.Round(random.NextDouble() * 900 + 100, 1);
                double value2 = Math.Round(random.NextDouble() * 900 + 100, 1);
                double value3 = Math.Round(random.NextDouble() * 900 + 100, 1);

                if (option == 1)
                {
                    Console.WriteLine("Úhlová rychlost: ? ");
                    Console.WriteLine("obvodová rychlost: " + value1);
                    Console.WriteLine("poloměr: " + value2);
                    hodnota1 = double.Parse(Console.ReadLine());
                    if (Math.Abs(hodnota1 - value1 / value2) < 0.1)
                        Console.WriteLine("Správná odpověď!");
                    else Console.WriteLine("Špatná odpověď :(");
                }

                if (option == 2)
                {
                    Console.WriteLine("poloměr: ? ");
                    Console.WriteLine("úhlová rychlost: " + value3);
                    Console.WriteLine("obvodová rychlost: " + value2);
                    hodnota2 = double.Parse(Console.ReadLine());
                    if (Math.Abs(hodnota2 - value1 / value3) < 0.1)
                        Console.WriteLine("Správná odpověď!");
                    else Console.WriteLine("Špatná odpověď :(");
                }

                if (option == 3)
                {
                    Console.WriteLine("obvodová rychlost: ? ");
                    Console.WriteLine("poloměr: " + value1);
                    Console.WriteLine("úhlová rychlost: " + value2);
                    hodnota3 = double.Parse(Console.ReadLine());
                    if (Math.Abs(hodnota3 - value1 * value2) < 0.1)
                        Console.WriteLine("Správná odpověď!");
                    else Console.WriteLine("Špatná odpověď :(");
                }

                Console.WriteLine("Chcete vytvořit další příklad? y = ano; n = ne");
                cely = Console.ReadLine();
                if (cely == "y")
                    opakovani = true;
                else if (cely == "n")
                    opakovani = false;
            }
        }
    }
}