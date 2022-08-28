
using System.ComponentModel.DataAnnotations;

namespace Domain.EntityFrameworkDictionary
{
    public class EntityFrameworkDictionary<T,G>
    {
        [Key]
        public int EntityFrameworkDictionaryID { get; set; }
        public ICollection<DictionaryItem<T,G>> Items { get; set; }

    }

    public class DictionaryItem<T,G>
    {
        [Key]
        public int DictionaryItemID { get; set; }
        public int EntityFrameworkDictionaryID { get; set; }
        public T Key { get; set; }
        public G Value { get; set; }
    }
}
