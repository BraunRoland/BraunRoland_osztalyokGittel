namespace OOPGyakorlas
{
    internal class Program
    {
        static void F01()
        {
            Konyv k1 = new("A Pál Utcai Fiúk", "Molnár Ferenc", 1906, 200, 4500);
            Konyv k2 = new("Készülő", "én");
            k1.Arnoveles(2000);
            k2.Arnoveles(1500);
            k1.Kedvezmeny(23);
            k2.Kedvezmeny(47);
            Console.WriteLine(k1.HanyOldalMaradt(100));
            Console.WriteLine(k2.HanyOldalMaradt(40));
            Console.WriteLine(k1);
            Console.WriteLine(k2);
        }

        static void F02()
        {
            Film f1 = new("Éjjeli féreg", "Dan Gilroy", 117, "thriller", true);
            Film f2 = new("Készül", "én");
            f1.Jatszas();
            f2.Jatszas();
            f1.MufajModositas("dráma");
            f2.MufajModositas("vígjáték");
            f1.HosszNovelese(21);
            f2.HosszNovelese(100);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
        }

        static void F03()
        {
            Karakter k1 = new("János", 23, 150, 6);
            Karakter k2 = new("Alma", 15);
            k1.Tamadas();
            k2.Tamadas();
            k1.Gyogyulas(3);
            k2.Gyogyulas(31);
            k1.Szintlepes();
            k2.Szintlepes();
            Console.WriteLine(k1);
            Console.WriteLine(k2);
        }

        static void F04()
        {
            Urhajo u1 = new("Apollo", 321, 4, 75);
            Urhajo u2 = new("Apollo 2", 7);
            u1.Indulas();
            u2.Indulas();
            u1.Tankolás(40);
            u2.Tankolás(10);
            u1.Landolás();
            u2.Landolás();
            Console.WriteLine(u1);
            Console.WriteLine(u2);
        }

        static void F05()
        {
            Kem k1 = new("047", "USA", 40, 12);
            Kem k2 = new("en", "HUN");
            k1.KuldetesInditasa();
            k2.KuldetesInditasa();
            k1.SikerEselyNovelese(20);
            k2.SikerEselyNovelese(30);
            k1.VeszelySzintNovelese(3);
            k2.VeszelySzintNovelese(7);
            Console.WriteLine(k1);
            Console.WriteLine(k2);
        }

        static void Main(string[] args)
        {
            F01();
            F02();
            F03();
            F04();
            F05();
        }
    }
}
