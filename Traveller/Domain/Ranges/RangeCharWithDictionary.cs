namespace Domain.Ranges.WithDictionary
{
    /// <summary>
    /// Este tipo no es compatible con EF
    /// </summary>
    public class RangeCharWithDictionary
    {
        public char Id;
        public Dictionary<char, string> Description ;
        public List<char> Values; 
    }
}
