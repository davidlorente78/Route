using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller.Data
{
    public static class MalasiaVisas
    {
        public static Visa freeVisa = new Visa
        {
            Country = 'M',
            Currency = '$',
            Fee = 0,
            Entries = 'S',
            Name = "Visado gratuito para estancias inferiores a 90 dias",
            Validity = 0,
            OnLine = false,
            Duration = 90,
            Category = "Visado gratuito para estancias interiores a 90 dias.",
            Extensible = true,

            ValidEntryPoints = new List<Destination> { MalasiaDestinations.PadangPesar, MalasiaDestinations.RantanPanjang }
        };


    
    }
}
