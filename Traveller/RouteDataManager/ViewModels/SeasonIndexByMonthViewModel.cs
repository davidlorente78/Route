using Domain.Ranges;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RouteDataManager.ViewModels
{
    public class SeasonIndexByMonthViewModel
    {
        public Dictionary<string, string> Country_SeasonDescription { get; set; } = new Dictionary<string, string>();
       
        public Month FilterMonth { get; set; } = new Month() {  Name="January" , MonthID = 1  };
           
        public SelectList SelectListMonth { get; set; }

    }
}
