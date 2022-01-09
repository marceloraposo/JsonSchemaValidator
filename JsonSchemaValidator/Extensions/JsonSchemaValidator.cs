using System.Linq;
using System.Collections.Generic;

namespace  JsonSchemaValidator.Extensions
{
    public static class JsonSchemaValidator
    {
        public static string ToFormatedHtmlString(this IList<string> lists)
        {
            string result = string.Empty;

            foreach (var item in lists)
            {
                result += string.Format("{0} {1}",item,"<br/>");
            }

            return result;
        }
    }
}