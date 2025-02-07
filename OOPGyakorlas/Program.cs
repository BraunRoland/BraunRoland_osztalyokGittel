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

        static void Main(string[] args)
        {
            F01();
            F02();
            F03();
        }
    }
}
