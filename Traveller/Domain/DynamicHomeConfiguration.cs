/// <summary>
/// Domain – Holds the Entities and Interfaces. It does not depend on any other project in the solution.
/// </summary>
namespace Traveller.Domain
{
    public class DynamicHomeConfiguration()
    {
        public bool Show {  get; set; }
        public int Order { get; set; }
    }
}
