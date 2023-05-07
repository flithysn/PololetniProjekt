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
            double value1 = Math.Round(random.NextDouble() * 1 + 28, 1);
            double value2 = Math.Round(random.NextDouble() * 50 + 25, 1);
            double value3 = Math.Round(random.NextDouble() * 9 + 14, 1);

            string[] Domacnost = { "Válec v pračce", "Gramofonní deska", "Odšťavňovač", "Vystavený talíř", "Google Maps Kamera 3000", "Vinylová deska", "Ručička na hodinách" , "Zadní kolo auta", "Zašpiněné kolo vlaku", "Přední vrtule letadla", "Kapitánův radar na loďi", "Přední kolo motorky", "Malé kolo dětského scooteru", "Rotovací mechanismus bicyklu", "Velká vrtule helikoptéry" , "střed turbíny", "Čerstvé umyté kolo vlaku", "Záložná vrtule helikoptéry, která se náhle začala otáčet, ", "Malá ručička na dětských hodinkách", "DVD Harryho Pottera", "CD" };

            Random rmd = new Random();
            int cislo = rmd.Next(Domacnost.Length);
            string Domaci = Domacnost[cislo];

            switch (option)
            {
                case 1:
                    Console.Write($"{Domaci} se otáčí obvodovou rychlostí {value2}cm/s s poloměrem o velikosti {value1}cm. Vypočtěte úhlovou rychlost.");
                    double answer1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Chcete nápovědu? ano/ne");
                    string input1 = Console.ReadLine();

                    if (input1.ToLower() == "ano")
                    {
                        Console.WriteLine("používáme vzorec:v = r * ω");
                        Console.WriteLine($"V tomto případě je v = {value2}cm/s a poloměr je r = {value1}cm");
                        Console.WriteLine("Chcete vypočítat odpověď sami? ano/ne");
                        string input2 = Console.ReadLine();

                        if (input2.ToLower() == "ano")
                        {
                            Console.WriteLine("Zadejte svou odpoveď:");
                            double userAnswer = double.Parse(Console.ReadLine());
                            Console.WriteLine(Math.Abs(userAnswer - value1 / value2) < 0.1 ? "Správná odpověď!" : $"Špatná odpověď: {Math.Round(value1 / value2, 1)} je správny výsledek, používáme vzorec: ω = v/r");
                        }
                        else
                        {
                            Console.WriteLine($"Správná odpověď: {Math.Round(value1 / value2, 1)} je správny výsledek, používáme vzorec: ω = v/r");
                        }
                    }
                    else
                    {
                        Console.WriteLine(Math.Abs(answer1 - value1 / value2) < 0.1 ? "Správná odpověď!" : $"Špatná odpověď: {Math.Round(value1 / value2, 1)} je správny výsledek, používáme vzorec: ω = v/r");
                    }
                    break;

                case 2:
                    Console.Write($"{Domaci} se otáčí úhlovou rychlostí o velikosti {value3} rad/s a obvodovou rychlostí o velikosti {value2} km/h. Vypočtěte poloměr.");
                    double answer2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Chcete nápovědu? ano/ne");
                    string input3 = Console.ReadLine();

                    if (input3.ToLower() == "ano")
                    {
                        Console.WriteLine("používáme vzorec:a = v^ω / r");
                        Console.WriteLine($"V tomto případě je r = {value3}rad/s a v = {value2}km/h, nezapomeňte převést km/h na m/s !");
                        Console.WriteLine("Chcete vypočítat odpověď sami? ano/ne");
                        string input5 = Console.ReadLine();

                        if (input5.ToLower() == "ano")
                        {
                            Console.WriteLine("Zadejte svou odpověď:");
                            double userAnswer = double.Parse(Console.ReadLine());
                            Console.WriteLine(Math.Abs(userAnswer - Math.Pow(value3 * 1000 / 3600, 2) / value2) < 0.1 ? "Správná odpověď!" : $"Špatná odpověď: {Math.Round(Math.Pow(value3 * 1000 / 3600, 2) / value2, 1)} je správný výsledek, používáme vzorec: a = v^2 / r");
                        }
                        else
                        {
                            Console.WriteLine($"Správná odpověď: {Math.Round(Math.Pow(value3 * 1000 / 3600, 2) / value2, 1)} je správný výsledek, používáme vzorec: a = v^ω / r");
                        }
                    }
                    else
                    {
                        Console.WriteLine(Math.Abs(answer2 - Math.Pow(value3 * 1000 / 3600, 2) / value2) < 0.1 ? "Správná odpověď!" : $"Špatná odpověď: {Math.Round(Math.Pow(value3 * 1000 / 3600, 2) / value2, 1)} je správný výsledek, používáme vzorec: a = v^2 / r");
                    }
                    break;

                case 3:
                    Console.Write($"{Domaci} s poloměrem o velikosti {value1}cm se otáčí s úhlovou rychlostí {value3}rad/s. Vypočtěte obvodovou rychlost gramofonní desky.");
                    double answer3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Chcete nápovědu? ano/ne");
                    string input4 = Console.ReadLine();
                        
                    if (input4.ToLower() == "ano")
                    {
                        Console.WriteLine("používáme vzorec:v = r * ω");
                        Console.WriteLine($"V tomto případě je poloměr r = {value1}cm a úhlová rychlost je ω = {value3}rad/s");

                     
                        Console.WriteLine("Chcete vypočítat odpověď sami? ano/ne");
                        string input2 = Console.ReadLine();

                        if (input2.ToLower() == "ano")
                        {
                            Console.WriteLine("Zadejte svou odpověď:");
                            double userAnswer = double.Parse(Console.ReadLine());
                            Console.WriteLine(Math.Abs(userAnswer - value1 * value3) < 0.1 ? "Správná odpověď!" : $"Špatná odpověď: {Math.Round(value1 * value3, 1)} je správný výsledek, používáme vzorec: v = r * ω");
                        }
                        else
                        {
                            Console.WriteLine($"Správná odpověď: {Math.Round(value1 * value3, 1)} je správný výsledek, používáme vzorec: v = r * ω");
                        }
                    }
                    else
                    {
                        Console.WriteLine(Math.Abs(answer3 - value1 * value3) < 0.1 ? "Správná odpověď!" : $"Špatná odpověď: {Math.Round(value1 * value3, 1)} je správný výsledek, používáme vzorec: v = r * ω");
                    }
                    break;
            }

            Console.WriteLine("Chcete vytvořit další příklad? ano/ne");
            string input = Console.ReadLine();
            if (input != "ano")
                repeat = false;
        }
    }
}
