using System.ComponentModel.DataAnnotations;

namespace UmbracoProject3.umbraco.models
{
    public class ContentForm
    {
        [Required]
        public string Name { get; set; } = "";
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = "";
        [Required]

        public string Subject { get; set; } = "";
        [Required]

        public string Message { get; set; } = ""; 

    }
}
