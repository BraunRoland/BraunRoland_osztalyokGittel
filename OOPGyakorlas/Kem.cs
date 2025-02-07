using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGyakorlas
{
    public class Kem
    {
        private string kodnev;
        private string orszag;
        private int veszelySzint;
        private int sikerEsely;

        public Kem(string kodnev, string orszag, int veszelySzint, int sikerEsely)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            this.veszelySzint = veszelySzint;
            this.sikerEsely = sikerEsely;
        }
        public Kem(string kodnev, string orszag)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            veszelySzint = 5;
            sikerEsely = 50;
        }

        public string Kodnev { get => kodnev; set => kodnev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
        public int SikerEsely { get => sikerEsely; set => sikerEsely = value; }

        public void KuldetesInditasa()
        {
            Console.WriteLine($"{kodnev} küldetése elkezdődött.");
        }

        public void VeszelySzintNovelese(int mennyiseg)
        {
            veszelySzint += mennyiseg;
        }

        public void SikerEselyNovelese(int szazalek)
        {
            sikerEsely += szazalek;
        }

        public override string? ToString()
        {
            return $"{kodnev} - {orszag}: Veszély szint: {veszelySzint} | Siker esélye: {sikerEsely}";
        }
    }
}
