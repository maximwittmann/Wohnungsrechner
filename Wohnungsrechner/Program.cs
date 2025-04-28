using System;
using Wohnungsrechner.Properties;

namespace Wohnungsrechner
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //ZIMMER
            Zimmer Schlafzimmer = new Zimmer("Schlafzimmer",10,5,3,2,1);
            Zimmer Bad = new Zimmer("Bad",3,4,5,76,3);
            //Wenn Konstruktor erstellt, kann man diese einzeilige Schreibweise verwenden            
            Zimmer Kueche = new Zimmer("Küche",3,4,5,76,3);
            /*Bei fehlenden Konstruktor
            Kueche.SetBezeichnung("Kueche"); 
            Kueche.SetLänge(10);
            Kueche.SetBreite(30);
            Kueche.SetHöhe(10);
            Kueche.SetAnzahlTüren(2);
            Kueche.SetAnzahlFenster(3);
           */
            Zimmer[] wohnung = new Zimmer[3];
            wohnung[0] = Schlafzimmer;
            wohnung[1] = Kueche;
            wohnung[2] = Bad;

            foreach (Zimmer z in wohnung)
            {
                z.Details();
            }
            
            
            //MÖBEL
            Möbel Sofa = new Möbel("Sofa","Stoff", "Rot", 130);
            Möbel Schrank = new Möbel("Schrank","Holz", "Weiß", 80);

            Möbel[] Ausstattung = new Möbel[2];
            Ausstattung[0] = Sofa;
            Ausstattung[1] = Schrank;

            foreach (Möbel m in Ausstattung)
            {
                m.Details();
            }
            
            
            //AUßENBEREICH
            Außenbereich Haus1 = new Außenbereich("Dachterasse", 10,15);
            Außenbereich Haus2 = new Außenbereich("Garten", 50, 40);

            Außenbereich[] außenbereiche = new Außenbereich[2];
            außenbereiche[0] = Haus1;
            außenbereiche[1] = Haus2;

            foreach (Außenbereich außen  in außenbereiche)
            {
                außen.Details();
            }
        }
    }
}