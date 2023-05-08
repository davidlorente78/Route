using Domain.Ranges;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RouteDataManager.ViewModels
{
    public class MonsoonIndexByMonthViewModel
    {
        public Dictionary<string, string> Country_MonsoonDescription { get; set; } = new Dictionary<string, string>();

        public Month FilterMonth { get; set; } = new Month() { Name = "January", Id = 1 };

        public SelectList SelectListMonth { get; set; }

    }
}
