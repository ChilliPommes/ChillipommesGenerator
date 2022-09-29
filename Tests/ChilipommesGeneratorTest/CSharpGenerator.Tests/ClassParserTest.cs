using ChillipommesGenerator.CSharpGenerator.Parser;
using ChillipommesGenerator.JsonGenerator.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChilipommesGeneratorTest.CSharpGenerator.Tests
{
    public class ClassParserTest
    {
        [Test]
        public void CreateCSharpClass_Test()
        {
            var classParser = new ClassParser();
            var jsonParser = new InterfaceParser("");

            var path = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
            var fileName = "TestJson.json";

            var fullPath = Path.Combine(path, fileName);
            var output = jsonParser.ParseJson(fullPath);

            classParser.CreateCSharpClass(output);
        }
    }
}
