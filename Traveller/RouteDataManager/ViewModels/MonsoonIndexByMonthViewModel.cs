﻿using Domain.Ranges;
using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class MonsoonIndexByMonthViewModel
    {
        public Dictionary<string, string> Country_MonsoonDescription { get; set; } = new Dictionary<string, string>();
       
        public Month FilterMonth { get; set; } = new Month() {  Name="January" , MonthID = 1  };
           
        public SelectList SelectListMonth { get; set; }

    }
}