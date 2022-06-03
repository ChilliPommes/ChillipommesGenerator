using System.Text;

namespace ChillipommesGenerator.Core.Dictionaries
{
    public sealed class TypeDictionary
    {
        public static byte[] CLASS_TYPE => Encoding.UTF8.GetBytes("class");

        public static byte[] PUBLIC_TYPE => Encoding.UTF8.GetBytes("public");

        public static byte[] PRIVATE_TYPE => Encoding.UTF8.GetBytes("private");

        public static byte[] PROTECTED_TYPE => Encoding.UTF8.GetBytes("protected");

        public static byte[] SEALED_TYPE_CSHARP => Encoding.UTF8.GetBytes("sealed");

        public static byte[] STATIC_TYPE => Encoding.UTF8.GetBytes("static");

        public static byte[] NAMESPACE_TYPE => Encoding.UTF8.GetBytes("namespace");

        public static byte[] BYTE_TYPE => Encoding.UTF8.GetBytes("byte");

        public static byte[] SHORT_TYPE => Encoding.UTF8.GetBytes("short");

        public static byte[] INT_TYPE => Encoding.UTF8.GetBytes("int");

        public static byte[] LONG_TYPE => Encoding.UTF8.GetBytes("long");

        public static byte[] FLOAT_TYPE => Encoding.UTF8.GetBytes("float");

        public static byte[] DOUBLE_TYPE => Encoding.UTF8.GetBytes("double");

        public static byte[] CHAR_TYPE => Encoding.UTF8.GetBytes("char");

        public static byte[] STRING_TYPE => Encoding.UTF8.GetBytes("string");

        public static byte[] OBJECT_TYPE => Encoding.UTF8.GetBytes("object");

        public static byte[] LIST_TYPE => Encoding.UTF8.GetBytes("List");

        public static byte[] IENUMERABLE_TYPE => Encoding.UTF8.GetBytes("IEnumerable");

        public static byte[] ENUM_TYPE => Encoding.UTF8.GetBytes("enum");

        public static byte[] ILIST_TYPE => Encoding.UTF8.GetBytes("IList");

        public static byte[] DATETIME_TYPE => Encoding.UTF8.GetBytes("DateTime");

        public static byte[] GENERIC_TYPE => Encoding.UTF8.GetBytes("T");

        public static byte[] WHERE_TYPE => Encoding.UTF8.GetBytes("where");

        public static byte[] USING_TYPE => Encoding.UTF8.GetBytes("using");

        public static byte[] INTERFACE_TYPE => Encoding.UTF8.GetBytes("interface");
    }
}
