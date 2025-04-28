using System;

namespace Wohnungsrechner.Properties
{
    public class Möbel
    {
        private string bezeichnung;
        private string material;
        private string farbe;
        private float preis;

        public Möbel(string bezeichnung, string material, string farbe, float preis)
        {
            this.bezeichnung = bezeichnung;
            this.material = material;
            this.farbe = farbe;
            this.preis = preis;
        }

        public void Details()
        {
            Console.WriteLine(GetBezeichnung());
            Console.WriteLine($"Material: {GetMaterial()}");
            Console.WriteLine($"Farbe: {GetFarbe()}");
            Console.WriteLine($"Kosten: {GetPreis()}");
        }
        
        public void SetBezeichnung()
        {
            this.bezeichnung = bezeichnung;
        }

        public string GetBezeichnung()
        {
            return bezeichnung;
        }
        
        public void SetMaterial()
        {
            this.material = material;
        }
        
        public string GetMaterial()
        {
            return material;
        }

        public void SetFarbe()
        {
            this.farbe = farbe;
        }

        public string GetFarbe()
        {
            return farbe;
        }

        public void SetPreis()
        {
            this.preis = preis;
        }

        public float GetPreis()
        {
            return preis;
        }
    }
}