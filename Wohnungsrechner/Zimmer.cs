using System;

namespace Wohnungsrechner
{
    public class Zimmer
    {
        //ATTRIBUTE
        private string bezeichnung;
        private double länge;
        private double breite;
        private double höhe;
        private int anzahlFenster;
        private int anzahlTueren;
        
        //CONSTRUCTORS
        public Zimmer(string bezeichnung, double länge, double breite, double höhe, int anzahlFenster, int anzahlTueren)
        {
            this.bezeichnung = bezeichnung;
            this.länge = länge;
            this.breite = breite;
            this.höhe = höhe;
            this.anzahlFenster = anzahlFenster;
            this.anzahlTueren = anzahlTueren;
        }

        //GETTER/SETTER
        public void SetBezeichnung(string bezeichung)
        {
            this.bezeichnung = bezeichnung;
        }

        public string GetBezeichnung()
        {
            return bezeichnung;
        }

        public void SetLänge(double länge)
        {
            this.länge = länge;
        }

        public double GetLänge()
        {
            return länge;
        }

        public void SetBreite(double breite)
        {
            this.breite = breite;
        }

        public double GetBreite()
        {
            return breite;
        }

        public void SetHöhe(double höhe)
        {
            this.höhe = höhe;
        }

        public double GetHöhe()
        {
            return höhe;
        }

        public void SetAnzahlTüren(int anzahlTueren)
        {
            this.anzahlTueren = anzahlTueren;
        }

        public int GetAnzahlTueren()
        {
            return anzahlTueren;
        }

        public void SetAnzahlFenster(int anzahlFenster)
        {
            this.anzahlFenster = anzahlFenster;
        }

        public int GetAnzahlFenster()
        {
            return anzahlFenster;
        }

        public double BerechneGrundflaeche()
        {
            double grundflaeche= länge * breite;
            return grundflaeche;
        }

        public double BerechneWandFlaeche()
        {
            double w1, w2, tf, ff;
            w1 = länge * höhe * 2;
            w2 = breite * höhe * 2;
            tf = anzahlTueren * 1 * 2;
            ff = anzahlFenster * 1 * 0.8;
            double wandflaeche = w1 + w2 - (tf + ff);
            return wandflaeche;
        }

        public void Details()
        {
            Console.WriteLine(GetBezeichnung());
            Console.WriteLine($"Grundfläche:{BerechneGrundflaeche()}");
            Console.WriteLine($"Wandfläche:{BerechneWandFlaeche()}");
        }
    }
}