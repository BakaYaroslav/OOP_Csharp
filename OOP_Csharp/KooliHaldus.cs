using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Csharp
{
   

    public class Koolihaldus
    {
        // Kapseldatud list
        private List<Isik> inimesed = new List<Isik>();

        public void LisaInimene(Isik isik)
        {
            inimesed.Add(isik);
        }

        public void KuvaKõik()
        {
            Console.WriteLine("\n--- KOOLI NIMEKIRI ---");
            foreach (var isik in inimesed)
            {
                // Polümorfism teeb siin imesid! 
                // C# teab ise, kas käivitada Õpetaja või Õpilase Kirjelda() meetod.
                isik.Kirjelda();
            }
        }

        public void OtsiNimeJärgi(string otsitavNimi)
        {

            Console.WriteLine($"OTSINGU TULEMUSED (päring {otsitavNimi})");
            bool leitud = false;

            foreach (var isik in inimesed)
            {
                if (isik.Nimi.Contains(otsitavNimi, StringComparison.OrdinalIgnoreCase))
                {
                    isik.Kirjelda();
                    Console.WriteLine("--------");
                    leitud = true;
                }
            }
        }
    }

   
}
