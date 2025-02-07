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
        static void Main(string[] args)
        {
            F01();
        }
    }
}
