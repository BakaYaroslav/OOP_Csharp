using System.Net.WebSockets;

namespace OOP_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Isik inimene1 = new Isik();
            //inimene1.Nimi = "Mati";
            //inimene1.Sünniaasta = 2000;
            //inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...

            Koolihaldus minuKool = new Koolihaldus();
            List<ITööline> palgasaajad = new List<ITööline>();
            Random rnd = new Random();
            ITööline[] toolised = new ITööline[3]
            {
                new Õpilane(),
                new Õpetaja(),
                new Üliõpilane()
            };

            //Õpetajad
            string[] õpetajaNimed = { "Marina", "Aleksei", "Katrin", "Dmitri", "Liisa" };
            int[] õpetajaSünniaastad = { 1975, 1982, 1990, 1995, 1988 };
            string[] ained = { "programmeerimine", "matemaatika", "füüsika", "keemia", "eesti keel" };
            double[] tunnitasud = { 13.8, 15.0, 12.5, 14.2, 16.0 };
            int[] tunnidKuus = { 120, 130, 140, 150, 160 };
            string[] hinne = { "1", "2", "3", "4", "5" };

            //Õpilased
            string[] õpilasNimed = { "Yaroslav", "Anna", "Peeter", "Maria", "Ivan" };
            int[] õpilasSünniaastad = { 2005, 2006, 2007, 2008, 2009 };
            string[] koolid = { "TTHK", "Gustav Adolfi Gümnaasium", "Tallinna Reaalkool" };
            int[] klassid = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] puudumised = { 0, 5, 10, 13, 20 };

            //Üliõpilane
            string[] kuurs = { "1", "2", "3", "4", "5" };

            //Direktor
            double[] lisatasu = { 100, 200, 300, 400, 500};
           

            Õppevorm[] vormid = (Õppevorm[])Enum.GetValues(typeof(Õppevorm)); // teeb list õppevormist


            Direktor direktor = new Direktor();
            direktor.Nimi = õpetajaNimed[rnd.Next(1, 5)];
            direktor.Sünniaasta = õpetajaSünniaastad[rnd.Next(1, 5)];
            direktor.Tunnitasu = tunnitasud[rnd.Next(1, 5)];
            direktor.Tunnidkuus = tunnidKuus[rnd.Next(1, 5)];
            direktor.Lisatasu = lisatasu[rnd.Next(1, 5)];
            palgasaajad.Add(direktor);
            direktor.ArvutaPalk();
            direktor.Kirjelda();

            Console.WriteLine("=======================================================");
            for ( int i = 0; i < 10; i++)
            {
               
                int randomIsik = rnd.Next(0, 3);
                var tooline = toolised[randomIsik];
                switch (tooline)
                {
                    case Üliõpilane:
                        Üliõpilane üliõpilane = new Üliõpilane();
                        üliõpilane.Nimi = õpilasNimed[rnd.Next(1, 5)];
                        üliõpilane.Sünniaasta = õpilasSünniaastad[rnd.Next(1, 5)];
                        üliõpilane.Kool = koolid[rnd.Next(1, 3)];
                        üliõpilane.Kuurs = kuurs[rnd.Next(1, 5)];
                        üliõpilane.Keskminehinne = rnd.NextDouble() * 5;
                        üliõpilane.Puudumised = puudumised[rnd.Next(1, 5)];
                        üliõpilane.SotsiaalAmet = rnd.Next(2) == 0; // random bool
                        üliõpilane.Staatus = vormid[rnd.Next(vormid.Length)];

                        üliõpilane.Kirjelda();
                        üliõpilane.Õpi();
                        üliõpilane.ArvutaPalk();
                        palgasaajad.Add(üliõpilane);
                        Console.WriteLine("===================================================");
                        break;


                    case Õpilane:

                        Õpilane õpilane = new Õpilane();
                        õpilane.Nimi = õpilasNimed[rnd.Next(1, 5)];
                        õpilane.Sünniaasta = õpilasSünniaastad[rnd.Next(1, 5)];
                        õpilane.Kool = koolid[rnd.Next(1, 3)];
                        õpilane.Klass = klassid[rnd.Next(1, 12)];
                        õpilane.Keskminehinne = rnd.NextDouble() * 5;
                        õpilane.Puudumised = puudumised[rnd.Next(1, 5)];
                        õpilane.SotsiaalAmet = rnd.Next(2) == 0; // random bool
                        õpilane.Staatus = vormid[rnd.Next(vormid.Length)];

                        õpilane.Kirjelda();
                        õpilane.Õpi();
                        õpilane.ArvutaPalk();
                        minuKool.LisaInimene(õpilane);
                        palgasaajad.Add(õpilane);
                        Console.WriteLine("===================================================");
                        break;

                   


                    case Õpetaja:

                        Õpetaja õpetaja = new Õpetaja();
                        õpetaja.Nimi = õpetajaNimed[rnd.Next(1, 5)];
                        õpetaja.Sünniaasta = õpetajaSünniaastad[rnd.Next(1, 5)];
                        õpetaja.Aine = ained[rnd.Next(1, 5)];
                        õpetaja.Tunnitasu = tunnitasud[rnd.Next(1, 5)];
                        õpetaja.Tunnidkuus = tunnidKuus[rnd.Next(1, 5)];
                        palgasaajad.Add(õpetaja);
                        õpetaja.Kirjelda();
                        õpetaja.Õpeta();
                        õpetaja.Hinda(hinne[rnd.Next(1, 5)]);
                        minuKool.LisaInimene(õpetaja);
                        Console.WriteLine("===================================================");
                        break;
                    default:
                        break;
                }
              
            }
            Console.WriteLine("---VÄLJAMAKSED---");
            foreach (ITööline isik in palgasaajad)
            {
                string tüüp = isik.VäljamakseTüüp.ToString();
                Console.WriteLine($"{tüüp}. summa: {isik.ArvutaPalk()} eurot. {((Isik)isik).Nimi}le");

            }

            Console.WriteLine("================MINU KOOL==================");
            minuKool.KuvaKõik();
            Console.Write("Kas sa tahad ostida keegi?: ");
            string Nimi = Console.ReadLine();
            minuKool.OtsiNimeJärgi(Nimi);
            //Õpetaja õpetaja1 = new Õpetaja();
            //õpetaja1.Nimi = "Marina";
            //õpetaja1.Sünniaasta = 1995;
            //õpetaja1.Aine = "programmeerimine";
            //õpetaja1.Kirjelda();
            //õpetaja1.Õpeta();
            //õpetaja1.Tunnitasu = 13.8;
            //õpetaja1.Tunnidkuus = 140;
            //õpetaja1.ArvutaPalk();
            //Console.WriteLine("===================================================");
            //Õpilane õpilane1 = new Õpilane();
            //õpilane1.Nimi = "Yaroslav";
            //õpilane1.Sünniaasta = 2008;
            //õpilane1.Kool = "TTHK";
            //õpilane1.Klass = 1;
            //õpilane1.Kirjelda();
            //õpilane1.Õpi();
            //õpilane1.Keskminehinne = 4;
            //õpilane1.Puudumised = 13;
            //õpilane1.SotsiaalAmet = true;
            //õpilane1.ArvutaPalk();
        }
    }    
}
