﻿using ChillipommesGenerator.JsonGenerator.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChilipommesGeneratorTest.JsonGenerator.Tests
{
    public class BaseParserTest
    {
        [Test]
        public void LoadFile_Test()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
            var fileName = "ITestInterface.cs";

            var fullPath = Path.Combine(path, fileName);

            var bp = new BaseParser();

            var payload = bp.LoadFile(fullPath);

            Assert.IsNotEmpty(payload);
        }
    }
}
