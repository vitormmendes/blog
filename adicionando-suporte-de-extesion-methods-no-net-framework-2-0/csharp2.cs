using System.Runtime.CompilerServices;

namespace ExtensionAppTeste
{
    public static class ExtensionMethods
    {
        public static string ToTitleCase(this string _string)
        {
            return System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(_string);
        }
    }
}