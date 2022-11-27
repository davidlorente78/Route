using Traveller.Domain;

namespace Data.EntityTypes
{
    public static class BorderCrossingTypes
    {
        public static BorderCrossingType Terrestrial = new BorderCrossingType { Code = 'F', Description = "Terrestrial" };
        public static BorderCrossingType Airport = new BorderCrossingType { Code = 'A', Description = "Airport" };
        public static BorderCrossingType Seaports = new BorderCrossingType { Code = 'S', Description = "Sea Port" };
    }
}
