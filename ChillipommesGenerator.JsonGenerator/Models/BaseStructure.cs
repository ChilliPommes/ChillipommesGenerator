using ChillipommesGenerator.Core.Enums;

namespace ChillipommesGenerator.JsonGenerator.Models
{
    public struct BaseStructure
    {
        public string ClassName { get; set; }

        public string NameSpace { get; set; }

        public string[] Usings { get; set; }

        public bool Sealed { get; set; }

        public bool Static { get; set; }

        public Accessebility Accessebility { get; set; }

        public PropertyStructure[] Properties { get; set; }

        public string InheritFromClass { get; set; }

        public string[] InheritFromInterfaces { get; set; }
    }
}
