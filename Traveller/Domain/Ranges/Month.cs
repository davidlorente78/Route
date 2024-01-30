using Domain.Generic;

namespace Domain.Ranges
{
    public class Month : Entity<int>
    {
        public int Order { get; set; }
        public string? Name { get; set; }
    }
}
