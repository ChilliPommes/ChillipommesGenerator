using System.Text.Json;

namespace ChillipommesGenerator.JsonGenerator.Resources
{
    public interface ITestInterface
    {
        public bool Foo { get; set; }

        public List<string> Bar { get; set; }

        public double Amount { get; set; }
    }
}
