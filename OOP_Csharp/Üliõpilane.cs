using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Csharp
{
    public class Üliõpilane : Õpilane
    {
        public string Eriala { get; set; }
        public string Kuurs { get; set; }

        public override void Kirjelda()
        {
            Console.WriteLine($"Üliõpilane {Nimi} õpib {Kuurs}. Kuursusel. Vorm: {Staatus}");
        }
    }
}
