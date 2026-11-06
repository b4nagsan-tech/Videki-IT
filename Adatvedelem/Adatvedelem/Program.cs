// bekérendő adatok: név nem kor SZ.I. szám 

Dictionary<string, int> jarmuvek = new();
Dictionary<string, int> jarmuvek = new();
List<string> jarmuvek = new();

Console.WriteLine("Elindítás (0)");
int i = int.Parse(Console.ReadLine());

while (true)
{
    Console.WriteLine("Jármű (0) Személy (1) Leállítás(2)");

    if (Console.ReadLine() == "0")
    {
        Console.WriteLine("Rendszám: ");
        string rendsz = Console.ReadLine();

        Console.WriteLine("Típusát: ");
        string tipus = Console.ReadLine();

        Console.WriteLine("Súly: ");
        double suly = double.Parse(Console.ReadLine());

        Console.WriteLine("Márka: ");
        string marka = Console.ReadLine();

        Console.WriteLine("Magasság: ");
        double magas = double.Parse(Console.ReadLine());
    }
    else if (Console.ReadLine() == "1")
    {
        Console.WriteLine("Név: ");
        string nev = Console.ReadLine();
        Console.WriteLine("Nem: ");
        string nem = Console.ReadLine();
        Console.WriteLine("Kor: ");
        int kor = int.Parse(Console.ReadLine());
        Console.WriteLine("Személyi szám: ");
        string szam = Console.ReadLine();
    }
    else if (Console.ReadLine() == "2")
    {
        Console.WriteLine("Leállítás");
        break;
    }
}