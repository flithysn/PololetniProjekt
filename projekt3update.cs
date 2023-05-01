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
            double value1 = Math.Round(random.NextDouble() * 20 + 160, 1);
            double value2 = Math.Round(random.NextDouble() * 26 + 83, 1);
            double value3 = Math.Round(random.NextDouble() * 18 + 213, 1);

            string[] Domacnost = { "Válec v pračce", "Gramofonní deska", "Odšťavňovač", "Vystavený talíř", "Google Maps Kamera 3000", "Vinylová deska", "Ručička na hodinách" };

            Random rmd = new Random();
            int cislo = rmd.Next(Domacnost.Length);
            string Domaci = Domacnost[cislo];

            string[] dopravniProstredek = { "Zadní kolo auta", "Zašpiněné kolo vlaku", "Přední vrtule letadla", "Kapitánův radar na loďi", "Přední kolo motorky", "Malé kolo dětského scooteru", "Rotovací mechanismus bicyklu", "Velká vrtule helikoptéry" };

            Random rnd = new Random();
            int index = rnd.Next(dopravniProstredek.Length);
            string nahodnyDopravniProstredek = dopravniProstredek[index];

            string[] nahodnost = { "střed turbíny", "Čerstvé umyté kolo vlaku", "Záložná vrtule helikoptéry, která se náhle začala otáčet, ", "Malá ručička na dětských hodinkách", "DVD Harryho Pottera", "CD" };

            Random rdm = new Random();
            int nahoda = rdm.Next(nahodnost.Length);
            string nahodnakulatost = nahodnost[nahoda];

            switch (option)
            {
                case 1:
                    Console.Write($"{Domaci} se otáčí obvodovou rychlostí {value2}cm/s s poloměrem o velikosti {value1}cm. Vypočtěte jeho úhlovou rychlost. ");
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
                    Console.Write($"Auto jedoucí rychlostí {value2}km/h se dostává do zatáčky s poloměrem {value1}m. Vypočtěte nutnou hodnotu bočního zrychlení auta. ");
                    double answer2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Chcete nápovědu? ano/ne");
                    string input3 = Console.ReadLine();

                    if (input3.ToLower() == "ano")
                    {
                        Console.WriteLine("používáme vzorec:a = v^2 / r");
                        Console.WriteLine($"V tomto případě je r = {value1}m a v = {value2}km/h");

                        // Pokud uživatel požádal o nápovědu, počkáme na další vstup uživatele, aby se ověřilo, zda chtějí vypočítat odpověď sami nebo ne
                        Console.WriteLine("Chcete vypočítat odpověď sami? ano/ne");
                        string input5 = Console.ReadLine();

                        if (input5.ToLower() == "ano")
                        {
                            Console.WriteLine("Zadejte svou odpověď:");
                            double userAnswer = double.Parse(Console.ReadLine());
                            Console.WriteLine(Math.Abs(userAnswer - Math.Pow(value2 * 1000 / 3600, 2) / value1) < 0.1 ? "Správná odpověď!" : $"Špatná odpověď: {Math.Round(Math.Pow(value2 * 1000 / 3600, 2) / value1, 1)} je správný výsledek, používáme vzorec: a = v^2 / r");
                        }
                        else
                        {
                            Console.WriteLine($"Správná odpověď: {Math.Round(Math.Pow(value2 * 1000 / 3600, 2) / value1, 1)} je správný výsledek, používáme vzorec: a = v^2 / r");
                        }
                    }
                    else
                    {
                        Console.WriteLine(Math.Abs(answer2 - Math.Pow(value2 * 1000 / 3600, 2) / value1) < 0.1 ? "Správná odpověď!" : $"Špatná odpověď: {Math.Round(Math.Pow(value2 * 1000 / 3600, 2) / value1, 1)} je správný výsledek, používáme vzorec: a = v^2 / r");
                    }
                    break;

                case 3:
                    Console.Write($"Gramofonová deska s poloměrem o velikosti {value1}cm se otáčí s úhlovou rychlostí {value3}rad/s. Vypočtěte obvodovou rychlost gramofonní desky. ");
                    double answer3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Chcete nápovědu? ano/ne");
                    string input4 = Console.ReadLine();

                    if (input4.ToLower() == "ano")
                    {
                        Console.WriteLine("používáme vzorec:v = r * ω");
                        Console.WriteLine($"V tomto případě je poloměr r = {value1}cm a úhlová rychlost je ω = {value3}rad/s");

                        // Pokud uživatel požádal o nápovědu, počkáme na další vstup uživatele, aby se ověřilo, zda chtějí vypočítat odpověď sami nebo ne
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

            Console.WriteLine("Chcete vytvořit další příklad? y = ano; n = ne");
            string input = Console.ReadLine();
            if (input != "y")
                repeat = false;
        }
    }
}
