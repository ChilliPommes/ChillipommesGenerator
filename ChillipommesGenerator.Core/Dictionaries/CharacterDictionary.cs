using System.Text;

namespace ChillipommesGenerator.Core.Dictionaries
{
    public sealed class CharacterDictionary
    {
        public static byte[] CURLY_BRACKED_OPEN => Encoding.UTF8.GetBytes("{");

        public static byte[] CURLY_BRACKED_CLOSE => Encoding.UTF8.GetBytes("}");

        public static byte[] SEMICOLON => Encoding.UTF8.GetBytes(";");

        public static byte[] WHITESPACE => Encoding.UTF8.GetBytes(" ");

        public static byte[] TAB_SPACE => Encoding.UTF8.GetBytes("  ");

        public static byte[] BRACKED_OPEN => Encoding.UTF8.GetBytes("(");

        public static byte[] BRACKED_CLOSED => Encoding.UTF8.GetBytes(")");

        public static byte[] SQUARE_BRACKED_OPEN => Encoding.UTF8.GetBytes("[");

        public static byte[] SQUARE_BRACKED_CLOSED => Encoding.UTF8.GetBytes("]");

        public static byte[] CROC_OPEN => Encoding.UTF8.GetBytes("<");

        public static byte[] CROC_CLOSED => Encoding.UTF8.GetBytes(">");

        public static byte[] DOUBLE_POINT => Encoding.UTF8.GetBytes(":");

        public static byte[] COMMA => Encoding.UTF8.GetBytes(",");

        public static byte[] LINEBREAK => Encoding.UTF8.GetBytes("\n");
    }
}
