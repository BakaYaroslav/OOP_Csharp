using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Csharp
{
    public class Õpetaja : Isik, ITööline, IHindaja
    {
        public string Aine { get; set; }

        public double Tunnitasu { get; set; }

        public int Tunnidkuus { get; set; }

        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Palk;

        public Õpetaja() : base() { }
        public Õpetaja(string aine, double tunnitasu, int tunnikuus)
        {
            Aine = aine;
            Tunnitasu = tunnitasu;
            Tunnidkuus = tunnikuus;
        }

        public override string Kirjelda()
        {
            string Õpetaja_kirjelda = $"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.";
            return Õpetaja_kirjelda;
        }
        public void Õpeta()
        { 
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }

        public virtual double ArvutaPalk()
        {
            Console.WriteLine($"Õpetaja palk on: {Tunnitasu * Tunnidkuus}");
            return Tunnitasu * Tunnidkuus;
        }
        public void Hinda(string hinne)
        {
            Console.WriteLine($"Õpetaja paneb: {hinne}");
        }


    }
}
