



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


            Õpetaja õpetaja1 = new Õpetaja();
            õpetaja1.Nimi = "Marina";
            õpetaja1.Sünniaasta = 1995;
            õpetaja1.Aine = "programmeerimine";
            õpetaja1.Kirjelda();
            õpetaja1.Õpeta();

            Õpilane õpilane1 = new Õpilane();
            õpilane1.Nimi = "Yaroslav";
            õpilane1.Sünniaasta = 2008;
            õpilane1.Kool = "TTHK";
            õpilane1.Klass = 1;
            õpilane1.Kirjelda();
            õpilane1.Õpi();
        }
    }    
}
