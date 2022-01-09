using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JsonSchemaValidator.Domain
{
    public class SchemaValidator
    {
        public static bool ValidateSchema(object schema, string jsonString)
        {
            JSchema jsonSchema = JSchema.Parse(schema.ToString());

            var jsonObject = JObject.Parse(jsonString);

            return jsonObject.IsValid(jsonSchema);
        }
        public static IList<string> ValidateSchema(object schema, string jsonString, out IList<string> validations)
        {
            JSchema jsonSchema = JSchema.Parse(schema.ToString());

            var jsonObject = JObject.Parse(jsonString);

            bool result = jsonObject.IsValid(jsonSchema, out validations);

            return validations;
        }
    }
}