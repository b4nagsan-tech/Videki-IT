// bekérendő adatok: név nem kor SZ.I. szám 
using System.IO;

while (true)
{
    Console.Write("Jármű (0) Személy (1) Leállítás(2): ");
    int meik = int.Parse(Console.ReadLine());

    if (meik == 0)
    {
        Console.Write("Rendszám: ");
        string rendsz = Console.ReadLine();

        Console.Write("Típusát: ");
        string tipus = Console.ReadLine();

        Console.Write("Súly: ");
        double suly = double.Parse(Console.ReadLine());

        Console.Write("Márka: ");
        string marka = Console.ReadLine();

        Console.Write("Magasság: ");
        double magas = double.Parse(Console.ReadLine());

        File.AppendAllText("adatbazis.txt", $"Jarmu,{rendsz},{tipus},{suly},{marka},{magas}\n");
    }
    else if (meik == 1)
    {
        Console.Write("Név: ");
        string nev = Console.ReadLine();

        Console.Write("Nem: ");
        string nem = Console.ReadLine();

        Console.Write("Kor: ");
        int kor = int.Parse(Console.ReadLine());

        Console.Write("Személyi igazolvány szám: ");
        string sziszam = Console.ReadLine();

        File.AppendAllText("adatbazis.txt", $"Szemely,{nev},{nem},{kor},{sziszam}\n");
    }
    else if (meik == 2)
    {
        Console.WriteLine("Leállítás");
        break;
    }
    else
    {
        Console.WriteLine("Hibás érték");
    }
}