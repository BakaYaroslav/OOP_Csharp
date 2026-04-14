using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Csharp
{
    public class Õpetaja : Isik
    {
        public string Aine { get; set; }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.");
        }
        public void Õpeta()
        { 
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }


    }
}
