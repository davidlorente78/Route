﻿using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class VietnamFrontiers
    {
        public static List<Frontier> Frontiers = new List<Frontier> {

                    new Frontier {
                        Name = "Cambodia Vietnam Bavet MocBai ",
                        Description  ="La frontera de Bavet / Moc Bai es la mas usada por los turistas pues te permite conectar en autobús Phnom Penh con Ho Chi Minh de la manera mas rápida y directa.",
                        Origin = CambodiaDestinations.Bavet,
                        TransitDestination = VietnamDestinations.MocBai,
                        Type = "T",
                        Visas = new List<Visa> { new Visa {  Duration = 30 } } }

                    ,

                    new Frontier {
                        Name = "Cambodia Vietnam Prek Chak Ha Tien ",
                        Description = "Si tu idea es cruzar a Vietnam por el sur de Camboya(o viceversa) la mejor manera es hacerlo por Prek Chak / Ha Tien.Por este paso fronterizo es fácil conectar la zona sur de Camboya(Sihanoukville, Kampot, Kep) con destinos como Chau Doc o Ho Chi Minh.",
                        Origin = CambodiaDestinations.PrekChak,
                        TransitDestination = VietnamDestinations.HaTien,
                        Type = "T",
                        Visas = new List<Visa> { new Visa { Duration = 30 } } }

                     ,

                    new Frontier {
                        Name = "Cambodia Vietnam Kaan Samnor / Ving Xuong ",
                        Description =" Kaan Samnor / Ving Xuong es el paso fronterizo que hay entre la frontera natural que es el río Mekong. Este paso fronterizo es el usado por aquellos viajeros que estando en Phnom Penh prefieren ir en barco hasta Vietnam y así empezar la ruta por el pais recorriendo los Delta del Mekong.La ruta en barco llega hasta la población de Chau Doc para continuar hasta Ho Chi Minh en autobús.",
                        Origin = CambodiaDestinations.KaanSamnor,
                        TransitDestination = VietnamDestinations.VingXuong,
                        Type = "T",
                        Visas = new List<Visa> { new Visa { Duration = 30 } } }

                     ,

                     new Frontier {
                        Name = VietnamDestinations.HAN.Name,
                        TransitDestination = VietnamDestinations.HAN,
                        Visas = new List<Visa> { new Visa { Duration = 30 } ,

                        } }

                         ,

                     new Frontier {
                        Name = VietnamDestinations.SGN.Name,
                        TransitDestination = VietnamDestinations.SGN,
                        Visas = new List<Visa> { new Visa { Duration = 30 } ,

                        } } ,

                     //No Vietnam visa on arrival for those going from Laos into Vietnam - must be pre-arranged.
                      new Frontier {
                        Name = "Bus from Vientiane",
                        Origin = LaosDestinations.Vientiane,
                        TransitDestination = VietnamDestinations.Hanoi,
                        Visas = new List<Visa> { new Visa { Duration = 30 }

                        } }

                        ,

                };
    }
}


//6WFC + 7C Na Ư, Taichang, Dien Bien, Vietnam
//Tay Trang, de reciente incorporación y con poco tráfico. El acceso al mismo era complicado y largo, si bien los paisajes del Norte de Laos son los más asombrosos de todo el país. La primera ciudad tras cruzar la frontera es Lai Chau, desde donde se puede ir a Sa Pa, un lugar dónde podemos realizar multitud de excursiones por las montañas, arrozales y poblados. Era nuestro preferido en caso de animarnos a ir a Sa Pa.