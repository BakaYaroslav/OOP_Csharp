using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Csharp
{
    public class Direktor : Õpetaja
    {
        public double Lisatasu { get; set; }



        public Direktor() : base() { }


        public override string Kirjelda()
        {
          string direktor_kirjelda = $"Mina olen direktor: {Nimi} ";
            return direktor_kirjelda;
        }
        public override double ArvutaPalk()
            {
            Console.WriteLine($"Direktor palk on: {base.ArvutaPalk() + Lisatasu}");
               return base.ArvutaPalk() + Lisatasu;
            }
    }
    
}
