using Domain.Generic;
using Traveller.Domain;

namespace Domain
{
    public class Nationality : Entity
    {
        public string Code { get; set; }
        public string? Description { get; set; }
        public ICollection<Visa> Visas { get; set; } = new List<Visa>();
    }
}
