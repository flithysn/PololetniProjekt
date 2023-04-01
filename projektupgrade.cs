using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool repeat = true;

        while (repeat)
        {
            int option = random.Next(1, 4);
            double value1 = Math.Round(random.NextDouble() * 50 + 30, 1);
            double value2 = Math.Round(random.NextDouble() * 50 + 30, 1);
            double value3 = Math.Round(random.NextDouble() * 50 + 30, 1);

            switch (option)
            {
                case 1:
                    Console.Write($"Válec v pračce se otáčí obvodovou rychlostí {value2}cm/s s poloměrem o velikosti {value1}cm. Vypočtěte jeho úhlovou rychlost. ");
                    double answer1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Abs(answer1 - value1 / value2) < 1 ? "Správná odpověď!" : $"Špatná odpověď :( ({value1 / value2} je správny výsledek, používáme vzorec:ω = v/r)");
                    break;

                case 2:
                    Console.Write($"Kolo autobusu se otáčí úhlovou rychlostí o velikosti {value3} rad/s a obvodovou rychlostí o velikosti {value2} cm/s. Vypočtěte poloměr tohoto kola. ");
                    double answer2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Abs(answer2 - value2 / value3) < 1 ? "Správná odpověď!" : $"Špatná odpověď :( ({value2 / value3} je správny výsledek, používáme vzorec:r = v/ω)");
                    break;

                case 3:
                    Console.Write($"Gramofonová deska s poloměrem o velikosti {value1}cm se otáčí s úhlovou rychlostí {value3}rad/s. Vypočtěte obvodovou rychlost gramofonní desky. ");
                    double answer3 = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Abs(answer3 - value1 * value2) < 1 ? "Správná odpověď!" : $"Špatná odpověď :( ({value1 * value3} je správný výsledek, používáme vzorec:v = r * ω)");
                    break;
            }

            Console.WriteLine("Chcete vytvořit další příklad? y = ano; n = ne");
            string input = Console.ReadLine();
            if (input != "y")
                repeat = false;
        }
    }
}