using ChillipommesGenerator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChillipommesGenerator.GUI
{
    internal class CSharpClassGui
    {
        public static ModelSchema ClassCreatorGui()
        {
            Renderer renderer = new Renderer();

            ModelSchema modelSchema = new ModelSchema();
            ClassSchema classSchema = new ClassSchema();
            CSharpSchema cSharpSchema = new CSharpSchema();

            renderer.AddLine("The following steps will create a C-Sharp class based on your inputs...");
            renderer.AddLine("");
            renderer.AddLine("");
            renderer.AddLine("Please insert the Class Name...");

            var name = Console.ReadLine();
            classSchema.Title = name;

            renderer.Clear();
            renderer.AddLine("Please insert a short description of the class...");
            var description = Console.ReadLine();
            classSchema.Description = description;

            renderer.Clear();

            modelSchema.Class = classSchema;

            return modelSchema;
        }
    }
}
