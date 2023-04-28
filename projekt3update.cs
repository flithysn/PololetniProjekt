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
                    Console.WriteLine(Math.Abs(answer1 - value1 / value2) < 0.1 ? "Správná odpověď!" : $"Špatná odpověď :( ({ Math.Round(value1 / value2, 1)} je správny výsledek, používáme vzorec:ω = v/r)");
                    break;

                case 2:
                    Console.Write($"{nahodnyDopravniProstredek} se otáčí úhlovou rychlostí o velikosti {value3} rad/s a obvodovou rychlostí o velikosti {value2} cm/s. Vypočtěte poloměr tohoto kola. ");
                    double answer2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Abs(answer2 - value2 / value3) < 0.1 ? "Správná odpověď!" : $"Špatná odpověď :( ({Math.Round(value2 / value3, 1)} je správny výsledek, používáme vzorec:r = v/ω)");
                    break;

                case 3:
                    Console.Write($"Gramofonová deska s poloměrem o velikosti {value1}cm se otáčí s úhlovou rychlostí {value3}rad/s. Vypočtěte obvodovou rychlost gramofonní desky. ");
                    double answer3 = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Abs(answer3 - value1 * value2) < 0.1 ? "Správná odpověď!" : $"Špatná odpověď :( ({Math.Round(value1 * value3, 1)} je správný výsledek, používáme vzorec:v = r * ω)");
                    break;
            }

            Console.WriteLine("Chcete vytvořit další příklad? y = ano; n = ne");
            string input = Console.ReadLine();
            if (input != "y")
                repeat = false;
        }
    }
}
