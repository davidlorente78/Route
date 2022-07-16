namespace Domain.Ranges.WithDictionary
{
    /// <summary>
    /// Este tipo no es compatible con EF
    /// </summary>
    public class RangeIntWithDictionary
    {
        public char Id;
        public Dictionary<int, string> Description ;
        public new List<int> Values; 
    }
}
