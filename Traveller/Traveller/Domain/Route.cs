using System;
using System.Collections.Generic;
using System.Text;
using Traveller.Data;
using Traveller.Data.Vietnam;

namespace Traveller
{
    public class Route
    {


        public List<Country> Countries = new List<Country>();
        
             

        public Route() {

            //https://www.tiansungi.com/border-crossing-laos-cambodia/

            

            Destination Singapore = new Destination { Name = "Singapore", CountryCode = 'G' };          
            Destination KUL = new Destination { Name = "Kuala Lumpur Airport", CountryCode = 'M' };         
            Destination SIN = new Destination { Name = "Singapore Changi Airport", CountryCode = 'G'};
            Destination HAK = new Destination { Name = "Haikou Airport", CountryCode = 'Z' };
            Destination SungaiKolok = new Destination { Name = "Sungai Kolok", CountryCode = 'M' };
            Destination PadangBesar = new Destination { Name = "Padang Besar", CountryCode = 'M' };


            Country Laos = new Country {
                Code = 'L',
                 Name ="Laos",
                Frontiers = LaosFrontiers.Frontiers,
                 Destinations = new List<Destination> { LaosDestinations.LPQ, LaosDestinations.VTE, LaosDestinations.VTE },
                Visas = new List<Visa> { LaosVisas.eLaoVisa, LaosVisas.LaoVisa }
            };

            Countries.Add(Laos);

            Country Vietnam = new Country
            {
                Code = 'V',
                Name = "Vietnam",
                Frontiers = VietnamFrontiers.Frontiers

            };

            Countries.Add(Vietnam);

            Country Thailand = new Country
            {
                Code = 'T',
                Name = "Thailand",

                Destinations = new List<Destination> { ThailandDestinations.BKK, ThailandDestinations.Mukdahan, ThailandDestinations.NongKhai },
                Frontiers = new List<Frontier> {

                    new Frontier {
                        Name = "Thailand Laos Frienship Bridge I ",
                        Origin = LaosDestinations.Vientiane,
                        Destination = ThailandDestinations.NongKhai,
                        Type = "T",
                        Visas = new List<Visa> { new Visa { Duration = 15 } } }

                    ,

                     new Frontier {
                        Name = "Thailand Laos Frienship Bridge II ",
                        Origin = ThailandDestinations.Mukdahan,
                        Destination = LaosDestinations.Savannakhet,
                        Type = "T",
                        Visas = new List<Visa> { new Visa { Duration = 15 } } } //Aqui se indica el visado que piden en Thailandia

                    ,

                     //Los aeropuertos son del Tipo A y no tienen Origen
                        new Frontier {
                        Origin = new Destination { Code = "A", CountryCode = 'A'}, //International Airport
                        Name = ThailandDestinations.BKK.Name,
                        Destination = ThailandDestinations.BKK,
                        Type ="A",
                        Visas = new List<Visa> { new Visa { Duration = 30 } ,

                        } },

                        new Frontier {
                        Name = "Padang Pesar - Padang Pesar (Pekan Siam)",
                        Origin = MalasiaDestinations.PadangPesar,
                        Destination = new Destination {  Name = "Padang Pesar", CountryCode= 'T'},
                         Type = "T",
                        Visas = new List<Visa> { new Visa { Duration = 30 } ,

                        } } ,

                        new Frontier {
                        Name = "Sungai Kolok - Rantan Panjang",
                        Origin = MalasiaDestinations.RantanPanjang,
                        Destination = new Destination {  Name = "Sungai Kolok", CountryCode= 'T'},
                        Type = "T",
                        Visas = new List<Visa> { new Visa { Duration = 30 } ,

                        } }

                }
            };


            Countries.Add(Thailand);


            Country SingaporeC = new Country
            {
                 Name ="Singapur",
                Code = 'I',
                Frontiers = new List<Frontier> {
                                  

                        new Frontier {
                        Name = SIN.Name,
                         Origin = new Destination { Code = "A", CountryCode = 'A'}, //International Airport
                        Destination = SIN,
                        Visas = new List<Visa> { new Visa { Duration = 90 } ,

                        } } ,

                        new Frontier {
                        Name = "Bus from Malaysia",
                        TransitDestination = Singapore,
                        Visas = new List<Visa> { new Visa { Duration = 90 } ,

                        } } 
                        
                                
                }
            };


            Country Malaysia = new Country
            {
                Code = 'M',
                Name = "Malaysia",
                Frontiers = new List<Frontier> {


                        new Frontier {
                        Name = KUL.Name,
                        Origin = new Destination { Code = "A", CountryCode = 'A'}, //International Airport
                        Destination = KUL,
                        Visas = new List<Visa>{ MalasiaVisas.freeVisa ,

                        } } ,

                        new Frontier {
                        Name = "Padang Pesar",
                        Origin = new Destination {  Name = "Padang Pesar", CountryCode= 'T'}, 
                        Destination = new Destination {  Name = "Padang Pesar", CountryCode= 'M'},
                        Visas = new List<Visa>{ MalasiaVisas.freeVisa ,

                        } } ,

                        new Frontier {
                        Name = "Sungai Kolok - Rantan Panjang",
                        Origin = new Destination {  Name = "Sungai Kolok", CountryCode= 'T'},
                        Destination = new Destination {  Name = "Sungai Kolok", CountryCode= 'M'},
                         Visas = new List<Visa>{ MalasiaVisas.freeVisa ,

                        } } ,


                }

                
            };


            Country China = new Country
            {
                Code = 'H',
                Frontiers = new List<Frontier> {


                        new Frontier {
                        Name = HAK.Name,
                        TransitDestination = HAK,
                        Visas = new List<Visa> { new Visa { Duration = 30 } ,

                        } }

                        //Pendiente Visita China Continental Visado Turistico 30 dias 


                }




            };

            
        }

    
    }
}
