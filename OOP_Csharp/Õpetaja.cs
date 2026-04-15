using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Csharp
{
    public class Õpetaja : Isik, ITööline
    {
        public string Aine { get; set; }

        public double Tunnitasu { get; set; }

        public int Tunnidkuus { get; set; }

        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Palk;

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.");
        }
        public void Õpeta()
        { 
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }

        public double ArvutaPalk()
        {
            Console.WriteLine($"Õpetaja palk on: {Tunnitasu * Tunnidkuus}");
            return Tunnitasu * Tunnidkuus;
        }


    }
}
