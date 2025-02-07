using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGyakorlas
{
    public class Urhajo
    {
        private string nev;
        private int sebesség;
        private int utasKapacítás;
        private int uzemanyagSzint;

        public Urhajo(string nev, int sebesség, int utasKapacítás, int uzemanyagSzint)
        {
            this.nev = nev;
            this.sebesség = sebesség;
            this.utasKapacítás = utasKapacítás;
            this.uzemanyagSzint = uzemanyagSzint;
        }

        public Urhajo(string nev, int utasKapacítás)
        {
            this.nev = nev;
            sebesség = 0;
            this.utasKapacítás = utasKapacítás;
            uzemanyagSzint = 100;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Sebesség { get => sebesség; set => sebesség = value; }
        public int UtasKapacítás { get => utasKapacítás; set => utasKapacítás = value; }
        public int UzemanyagSzint { get => uzemanyagSzint; set => uzemanyagSzint = value; }

        public void Indulas()
        {
            sebesség += 5;
            uzemanyagSzint -= 10;
        }

        public void Mennyiseg(int mennyiseg)
        {
            uzemanyagSzint += mennyiseg;
        }

        public void landolás()
        {
            sebesség = 0;
        }

        public override string? ToString()
        {
            return $"{nev}: sebssség: {sebesség} | Kapacítás: {UtasKapacítás} | Üzemanyag: {uzemanyagSzint}%";
        }
    }
}
