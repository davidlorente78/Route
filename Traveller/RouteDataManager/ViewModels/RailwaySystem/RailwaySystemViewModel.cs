using System;
using System.ComponentModel.DataAnnotations;

namespace RouteDataManager.ViewModels.RailwaySystem
{
    public class RailwaySystemViewModel : EditImageViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
