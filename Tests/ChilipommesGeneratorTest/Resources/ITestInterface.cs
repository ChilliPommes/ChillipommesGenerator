using System.Text.Json;

namespace ChillipommesGenerator.JsonGenerator.Resources
{
    public interface ITestInterface
    {
        [DataMember(Name = "foo")]
        public bool Foo { get; set; }

        [DataMember(Name = "bar")]
        public List<string> Bar { get; set; }

        [DataMember(Name = "amount")]
        public double Amount { get; set; }
    }
}
