using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller.Data
{
    public static class MalasiaDestinations
    {
       
        public static Destination Butterworth = new Destination { Name = "Butterworth", Type = 'R', CountryCode = 'M', };       
        public static Destination PadangPesar = new Destination { Name = "Padang Pesar", Type = 'F', CountryCode  = 'M', };
        public static Destination RantanPanjang = new Destination { Name = "Rantan Panjang", Type = 'F', CountryCode = 'M', };
        public static Destination KotaBahru = new Destination { Name = "Kota Bahru", Type = 'T', CountryCode = 'M', };
        public static Destination Penang = new Destination { Name = "Penang", Type = 'T', CountryCode = 'M', };
        public static Destination KualaLumpur = new Destination { Name = "Kuala Lumpur", Type = 'T', CountryCode = 'M', };
    }
}
