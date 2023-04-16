using System.ComponentModel.DataAnnotations;

namespace RouteDataManager.ViewModels.Destination
{
    public class DestinationViewModel : EditImageViewModel
    {
        public int DestinationID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public string Description { get; set; }

        public int CountryID { get; set; }
    }
}
