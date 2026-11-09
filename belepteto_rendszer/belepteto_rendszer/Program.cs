// bekérendő adatok: név nem kor SZ.I. szám 
using System.IO;
FileInfo info = new("adatbazis.txt");

Console.WriteLine("Üdvözöljük!");
Console.WriteLine();

while (true)
{
    Console.Write("Adatbevitel (0) Adatbázis megtekintése (1) Keresés (2) Leállítás (3): ");
    int meik = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (meik == 0)
    {
        Console.Write("Jármű (0) Személy (1): ");
        int meik2 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (meik2 == 0)
        {
            DateTime idomost = DateTime.Now;

            Console.Write("Rendszám: ");
            string rendsz = Console.ReadLine();

            Console.Write("Típusát: ");
            string tipus = Console.ReadLine();

            Console.Write("Súly (kg): ");
            double suly = double.Parse(Console.ReadLine());

            Console.Write("Márka: ");
            string marka = Console.ReadLine();

            Console.Write("Szín: ");
            string szin = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("A járművet sikeresen elmentettük az adatbazis.txt-be");
            Console.WriteLine();

            File.AppendAllText("adatbazis.txt", $"{idomost:f};Jarmu;{rendsz};{tipus};{suly};{marka};{szin}\n");
        }

        else if (meik2 == 1)
        {
            DateTime idomost = DateTime.Now;

            Console.Write("Név: ");
            string nev = Console.ReadLine();

            Console.Write("Nem (férfi / nő): ");
            string nem = Console.ReadLine();

            Console.Write("Kor: ");
            int kor = int.Parse(Console.ReadLine());

            Console.Write("Személyi igazolvány szám: ");
            string sziszam = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("A személyt sikeresen elmentettük az adatbazis.txt-be");
            Console.WriteLine();

            File.AppendAllText("adatbazis.txt", $"{idomost:f};Szemely;{nev};{nem};{kor};{sziszam}\n");
        }
    }

    else if (meik == 1)
    {
        foreach (string sor in File.ReadLines("adatbazis.txt"))
        {
            Console.WriteLine(sor);
            Console.WriteLine();
        }
    }

    else if (meik == 2)
    {
        Console.Write("Mit keress: ");
        string keress = Console.ReadLine();
        Console.WriteLine();

        bool benne = false;
        string josor = "";

        foreach (string sor in File.ReadLines("adatbazis.txt").Skip(1))
        {
            if (sor.Contains(keress))
            {
                benne = true;
                josor = sor;
                break;
            }
        }
        if (benne == true)
        {
            Console.WriteLine(josor);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Nem található adat!");
            Console.WriteLine();
        }
    }

    else if (meik == 3)
    {
        Console.WriteLine("Leállítás");
        break;
    }

    else
    {
        Console.WriteLine("Hibás érték");
        Console.WriteLine();
    }
}