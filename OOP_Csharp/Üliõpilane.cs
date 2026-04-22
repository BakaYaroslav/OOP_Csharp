using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Csharp
{
    public class Üliõpilane : Õpilane
    {
        public string Eriala { get; set; }
        public string Kuurs { get; set; }

        public override string Kirjelda()
        {
            string üli_õpilane = $"Üliõpilane {Nimi} õpib {Kuurs}. Kuursusel. Vorm: {Staatus}";
            return üli_õpilane;
        }
    }
}
