# Procvičování úhlové rychlosti ve fyzice
1. **Cíl projektu** Tato aplikace má za úkol pomoct studentům s fyzikou, přesněji s úhlovým pohybem. Aplikace náhodně vylosuje jednu ze tří možností: Úhlový pohyb, poloměr nebo celkovou rychlost. Poté se náhodně vygenerují hodnoty, se kterými budou studenti počítat. 
2. **Zvolené technologie:** Visual Studio 2022, C#, Bool, Random Number Generator, Obtížnost: Jednoduchá

#  Co aplikace dělá:
Tento program slouží jako nápovědní program pro fyzikální výpočty.

Hlavní funkcí programu je vytváření náhodných úloh z oblasti fyziky a matematiky, které uživatel musí vyřešit.

Program obsahuje širokou škálu vzorců a principů fyzikálních výpočtů, které uživatelé mohou použít jako nápovědu při řešení úloh.

Vzorce jsou uspořádány podle témat, takže uživatelé snadno najdou potřebné informace.

Program umožňuje uživatelům vložit hodnoty do vzorců a automaticky vypočítá výsledky.

Program obsahuje nápovědu, která uživatelům poskytuje informace o fyzikálních jednotkách, základních principech fyziky a matematiky, a další užitečné informace.

Uživatelé mohou využít interaktivních animací a videí, které jim pomohou lépe porozumět fyzikálním jevům a principům.

Tento program je velmi užitečný nástroj pro studenty a profesionály v oblasti fyziky a matematiky, kteří potřebují podporu při řešení výpočtů a porozumění fyzikálním principům.


# Popis použitých technologií:
Tento kód je napsán v programovacím jazyce C# a využívá .NET frameworku.

Hlavní třída je nazvaná Program a obsahuje metodu Main, která je vstupním bodem programu.

Pro generování náhodných hodnot se využívá třída Random, která je součástí .NET frameworku.

Pro práci s matematickými funkcemi se využívá třída Math, která také patří do .NET frameworku. Konkrétně se používají funkce Math.Round a Math.Pow.

Program obsahuje smyčku while, která opakuje generování náhodných hodnot a zobrazuje uživateli úkoly, které musí vyřešit.

Pro práci s uživatelským vstupem a výstupem se využívá třída Console, která také patří do .NET frameworku.

Celý kód je napsán v jazyce C# a běží v prostředí .NET frameworku, takže kód je závislý na této technologii.

#  Stručný popis jak to funguje uvnitř:
Tento kód je konzolová aplikace, která generuje matematické otázky, týkající se úhlových rychlostí, bočních zrychlení, poloměrů a rychlosti rotace objektů. Aplikace se skládá z několika hlavních prvků:

Random - třída, která generuje náhodná čísla.

double - datový typ, který umožňuje práci s desetinnými čísly.

string[] - datový typ, který umožňuje práci s řetězci.

switch - příkaz, který umožňuje testování více podmínek.

Console.ReadLine() - příkaz, který čte vstup uživatele z konzole.

if - příkaz, který umožňuje testování podmínek.

while - příkaz, který opakuje blok kódu, dokud je splněna určitá podmínka.

Po spuštění programu se aplikace začne opakovat v nekonečné smyčce, dokud uživatel neukončí program. V každém průchodu smyčkou se vygenerují náhodné hodnoty pro poloměry, rychlosti a objekty, ke kterým se vztahují matematické otázky. Následně se pomocí switch konstrukce vybere náhodná matematická otázka a na základě toho se vypočítá správná odpověď.

Pokud uživatel potřebuje nápovědu, aplikace mu poskytne informace o použitých vzorcích a vypočítá správnou odpověď. Pokud uživatel odpoví správně, aplikace mu to sdělí a pokud odpoví špatně, aplikace mu řekne, jaká byla správná odpověď. Pokud uživatel zadá chybný vstup, aplikace mu to řekne a požádá ho o správný vstup.

#  Návod na použití projektu

Tento kód je interaktivní program pro procvičování výpočtů úhlové rychlosti v souvislosti s fyzikálními situacemi.

Program generuje náhodné situace a zadává uživateli otázky, aby vypočetl odpovídající hodnoty.

Postup pro použití programu:

Otevřete vývojové prostředí s podporou jazyka C#.

Zkopírujte kód do nového projektu.

Upravte kód podle svých potřeb, například přidáním dalších fyzikálních situací nebo upravením seznamu předmětů v poli Domacnost.

Spusťte program.

Program vygeneruje náhodnou fyzikální situaci a zobrazí výzvu, aby uživatel vypočetl odpovídající hodnoty.

Uživatel může vyžádat nápovědu pro výpočet odpovědi pomocí vzorce a poté zadat odpověď.

Pokud je odpověď správná, program zobrazí upozornění o správnosti odpovědi.

Pokud je odpověď špatná, program zobrazí správnou odpověď a upozornění na špatnost odpovědi uživatele.

Program opakuje kroky 5 až 8, dokud uživatel nezadá "ne" jako odpověď na dotaz "Chcete pokračovat v procvičování?".


#  Možný rozvoj v budoucnu / Popis reálného využití projektu:

Projekt může sloužit jako učební pomůcka pro studenty fyziky a mechaniky k procvičování fyzikálních a matematických konceptů v praxi.

Projekt lze rozšířit o další vzorce a příklady, aby zahrnoval více témat a poskytoval užitečné nástroje pro výuku a procvičování fyzikálních konceptů.

Dalším možným rozšířením projektu by mohlo být přidání grafického rozhraní, které by umožňovalo uživatelům vizualizovat a zadávat hodnoty pomocí vizuálních grafů a diagramů.

Vylepšení projektu by mohlo zahrnovat rozšíření do dalších oblastí, například termodynamiku, elektromagnetismus nebo kvantovou fyziku, a poskytovat tak užitečný nástroj pro studenty a profesionály v různých oborech.
