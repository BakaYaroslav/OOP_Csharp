using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace OOP_Csharp
{
   
    public class Õpilane : Isik, ITööline
    {
        public string Kool { get; set; }
        public int Klass { get; set; }
        public double Keskminehinne { get; set; }
        public int Puudumised { get; set; } = 0;

        public bool SotsiaalAmet { get; set; }

        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Toetus;

        public Õppevorm Staatus { get; set; } = Õppevorm.Päevane;

        public Õpilane() : base() {  }

        public Õpilane(string nimi, string kool, int klass, Õppevorm staatus) : base(nimi)
        {
            Kool = kool;
            Klass = klass;
            Nimi = nimi;
            Staatus = staatus;
        }

        public override string Kirjelda()
        {
            string õpilane_kirjelda = $"{Nimi} õpib {Klass}. klassis. Vorm: {Staatus}. Kool: {Kool}.";
            return õpilane_kirjelda;
        }


        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
        }



        double Põhitoestus = 0;
        double Eritoetust = 0;
        public double ArvutaPalk()
        {
            if (Keskminehinne > 3.8F && Puudumised < 30)
            {
                Põhitoestus = 60;
                Console.WriteLine("Õpilanel on põhitoetust");
                
            }

            if (SotsiaalAmet)
            {
                 Eritoetust = 120;
                 Console.WriteLine("Õpilanel on eritoetust");
            }
            Console.WriteLine($"Õpilane palk on: {Põhitoestus + Eritoetust}");

                return  Põhitoestus + Eritoetust;



        }
    }
}
