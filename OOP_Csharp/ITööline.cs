using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Csharp
{
    public enum TööTüüp
    {
        Palk,
        Toetus
    }

    public enum Õppevorm
    {
        Päevane,
        Kaugõpe,
        Ekstern,
        AkadeemilinePuhkus
    }
    internal interface ITööline
    {
        TööTüüp VäljamakseTüüp { get; set; }
        double ArvutaPalk();

    }
}
