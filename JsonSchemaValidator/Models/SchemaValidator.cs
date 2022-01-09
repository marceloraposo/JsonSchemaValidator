using System;
using System.ComponentModel.DataAnnotations;

namespace JsonSchemaValidator.Models
{
    public class SchemaValidator
    {
        [Required]
        [MaxLength(5000)]
        public string Schema { get; set; }

        [Required]
        [MaxLength(5000)]
        public string Data { get; set; }

        public string Errors { get; set; }
    }
}
