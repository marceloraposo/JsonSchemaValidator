using System.Linq;
using System.Collections.Generic;

namespace  JsonSchemaValidator.Extensions
{
    public static class JsonSchemaValidator
    {
        public static string ToFormatedHtmlString(this IList<string> lists)
        {
            return string.Join("<br/>", lists);
        }
    }
}