using ChillipommesGenerator.Core.Models;
using ChillipommesGenerator.Core.Parser;
using System.Text;

namespace ChillipommesGenerator.CSharpGenerator.Parser
{
    public class ClassParser : BaseParser
    {
        public void CreateCSharpClass(ModelSchema modelSchema)
        {
            var classString = LoadFile("Resources\\EmptyClass.txt");
            var propertyString = LoadFile("Resources\\EmptyProperty.txt");

            classString = classString
                .ParseBascisc(modelSchema);

            var propertyStrings = propertyString.Replace("\0", "").ParseProperties(modelSchema);

            classString = classString.Replace("{{Properties}}", propertyStrings);

            classString = classString.Replace("\0", "");

            using (var fs = File.Create(modelSchema.Class.Title + ".cs"))
            {
                fs.Write(Encoding.UTF8.GetBytes(classString));
                fs.Flush();
            }
        }
    }
}
