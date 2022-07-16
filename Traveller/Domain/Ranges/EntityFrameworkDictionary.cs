
using System.ComponentModel.DataAnnotations;

namespace Domain.EntityFrameworkDictionary
{
    
    public class EntityFrameworkDictionary<T>
    {
        [Key]
        public int EntityFrameworkDictionaryID { get; set; }
        public ICollection<DictionaryItem<T>> Dictionary { get; set; }
       

    }


    public class DictionaryItem<T>{

        [Key]
        public int DictionaryItemID { get; set; }
        public int EntityFrameworkDictionaryID { get; set; }
        public T DictionaryKey { get; set; }
        public string DictionaryValue { get; set; }
    }
}
