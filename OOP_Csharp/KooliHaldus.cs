using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.IO;

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

        public void LisaInimene(List<Isik> uuedInimesed)
        {
           
            inimesed.AddRange(uuedInimesed);
            foreach ( var isik in inimesed)
                Console.WriteLine($"Lisati {isik.Nimi} uue inimene.");
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

        public void Otsi(string otsitavNimi)
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

        public void Otsi(int sünniaasta)
        {
            Console.WriteLine($"\nOtsime kedagi, kes on sündinud aastal: {sünniaasta}");
            bool leitud = false;
           
            foreach (var isik in inimesed)
            {
                if (isik.Sünniaasta == sünniaasta)
            {
                isik.Kirjelda();
                Console.WriteLine("--------");
                leitud = true;
            }
            }
        }

        public void SalvestaFaili(string failinimi)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(failinimi, false, Encoding.UTF8))
                {
                    sw.WriteLine($"---Kooli nimekiri (Salvestatud: {DateTime.Now}---");

                    foreach (var isik in inimesed)
                    {
                        sw.WriteLine(isik.Kirjelda());

                    }
                    Console.WriteLine($"Andmed on salvestatud faili: {failinimi}.txt");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Viga salvestamisel: {e.Message}");
            }
           
            
            

        }




    }

   
}
