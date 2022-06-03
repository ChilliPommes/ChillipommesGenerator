using ChillipommesGenerator.Core.Enums;

namespace ChillipommesGenerator.JsonGenerator.Models
{
    public struct PropertyStructure
    {
        public string PropertyName { get; set; }

        public string PropertyType { get; set; }

        public Accessebility Accessebility { get; set; }
        
        public bool Static { get; set; }
    }
}
