using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        while (true)
        {
            int option = random.Next(1, 4);
            double value1 = Math.Round(random.NextDouble() * 30 + 60, 1);
            double value2 = Math.Round(random.NextDouble() * 90 + 10, 1);
            double value3 = Math.Round(random.NextDouble() * 10 + 40, 1);

            string[] Domacnost = { "Válec v pračce", "", "Gramofonní deska", "Odšťavňovač", "Vystavený talíř", "Kamera 3000", "Vinylová deska", "ručička na hodinách" };
            string[] dopravniProstredek = { "Zadní kolo auta", "Zašpiněné kolo vlaku", "Přední vrtule letadla", "Kapitánův radar na loďi", "Přední kolo motorky", "Malé kolo dětského scooteru", "Rotovací mechanismus bicyklu", "Velká vrtule helikoptéry" };

            string randomObject = option == 1 ? Domacnost[random.Next(Domacnost.Length)] : dopravniProstredek[random.Next(dopravniProstredek.Length)];
            double answer = 0;

            switch (option)
            {
                case 1:
                    Console.Write($"{randomObject} se otáčí obvodovou rychlostí {value2}cm/s s poloměrem o velikosti {value1}cm. Vypočtěte jeho úhlovou rychlost. ");
                    answer = value1 / value2;
                    break;

                case 2:
                    Console.Write($"{randomObject} se otáčí úhlovou rychlostí o velikosti {value3} rad/s a obvodovou rychlostí o velikosti {value2} cm/s. Vypočtěte poloměr tohoto kola. ");
                    answer = value2 / value3;
                    break;

                case 3:
                    Console.Write($"Gramofonová deska s poloměrem o velikosti {value1}cm se otáčí s úhlovou rychlostí {value3}rad/s. Vypočtěte obvodovou rychlost gramofonní desky. ");
                    answer = value1 * value3;
                    break;
            }

            double userInput = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(userInput - answer) < 1 ? "Správná odpověď!" : $"Špatná odpověď :( ({answer} je správný výsledek)");

            Console.WriteLine("Chcete vytvořit další příklad? y = ano; n = ne");
            if (Console.ReadLine() != "y")
                break;
        }
    }
}
