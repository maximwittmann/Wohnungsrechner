using System;
using System.Runtime.CompilerServices;

namespace Wohnungsrechner.Properties
{
    public class Außenbereich
    {
        private string art;
        private float breite;
        private float laenge;


        public Außenbereich(string art,float breite,float laenge)
        {
            this.art = art;
            this.breite = breite;
            this.laenge = laenge;
        }

        public void SetArt()
        {
            this.art = art;
        }

        public string GetArt()
        {
            return art;
        }

        public void SetBreite()
        {
            this.breite = breite;
        }

        public float GetBreite()
        {
            return breite;
        }

        public void SetLaenge()
        {
            this.laenge = laenge;
        }

        public float GetLaenge()
        {
            return laenge;
        }

        public void Details()
        {
            Console.WriteLine(GetArt());
            Console.WriteLine($"Breite: {GetBreite()}m");
            Console.WriteLine($"Länge: {GetLaenge()}m");
        }
    }

    
}