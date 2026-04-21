using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Csharp
{
    public class Direktor : Õpetaja
    {
        public double Lisatasu { get; set; }


             public override double ArvutaPalk()
            {
            Console.WriteLine($"Direktor palk on: {base.ArvutaPalk() + Lisatasu}");
               return base.ArvutaPalk() + Lisatasu;
            }
    }
    
}
