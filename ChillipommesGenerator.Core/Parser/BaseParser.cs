using System.Text;

namespace ChillipommesGenerator.Core.Parser
{
    public class BaseParser
    {
        public string LoadFile(string fileName)
        {
            using var fs = File.OpenRead(fileName);

            using var ms = new MemoryStream();

            byte[] stepBlob = new byte[64];
            int offset = 0;
            int position = -1;
            do
            {
                int readLength = (fs.Length - offset) > 64 ? 64 : (int)(fs.Length - offset);

                position = fs.Read(stepBlob, 0, 64);

                if (position != 0)
                {
                    ms.Write(stepBlob);
                    stepBlob = new byte[64];
                    offset += 64;
                }
            } while (position != 0);

            return Encoding.UTF8.GetString(ms.ToArray());
        }
    }
}
