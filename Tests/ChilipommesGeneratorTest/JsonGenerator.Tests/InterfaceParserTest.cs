using ChillipommesGenerator.JsonGenerator.Parser;

namespace ChilipommesGeneratorTest.JsonGenerator.Tests
{
    public class InterfaceParserTest
    {
        [Test]
        public void Parse_Test()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
            var fileName = "ITestInterface.cs";

            var fullPath = Path.Combine(path, fileName);

            var ip = new InterfaceParser();

            var output = ip.Parse(fullPath);

            Assert.IsNotEmpty(output);
        }
    }
}
