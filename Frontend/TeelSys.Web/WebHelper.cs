using System.Linq;

namespace TeelSys.Web
{
    public static class WebHelper
    {
        public static string UrlCombine(string firstPart, string secondPart)
        {
            if (firstPart == "" || secondPart == "")
                return firstPart + secondPart;

            bool firstEndsWithSlash = firstPart.Last() == '/';
            bool secondStartsWithSlash = secondPart.First() == '/';

            if (firstEndsWithSlash && secondStartsWithSlash)
            {
                return firstPart + secondPart.Substring(1);
            }
            else if (firstEndsWithSlash || secondStartsWithSlash)
            {
                return firstPart + secondPart;
            }

            return firstPart + "/" + secondPart;
        }
    }
}
