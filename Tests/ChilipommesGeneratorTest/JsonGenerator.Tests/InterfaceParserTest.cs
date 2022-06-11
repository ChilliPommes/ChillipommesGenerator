using ChillipommesGenerator.JsonGenerator.Parser;
using System.Text.Json;

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

            var ip = new InterfaceParser("test.de");

            var output = ip.Parse(fullPath);

            Assert.IsNotEmpty(output);
        }

        [Test]
        public void Parse_Json_Test()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
            var fileName = "TestJson.json";

            var fullPath = Path.Combine(path, fileName);

            var ip = new InterfaceParser("test.de");
            ip.ParseJson(fullPath);

        }
    }
}
