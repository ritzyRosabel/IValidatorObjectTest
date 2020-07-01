using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvalidatorObjectTest
{
    public class LoginModel:IValidatableObject
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            if (String.IsNullOrEmpty(Username))
            {
                results.Add(new ValidationResult(" The username cannot be empty"));

            } 
            if (String.IsNullOrEmpty(Password))
            {
                results.Add(new ValidationResult(" The username cannot be empty"));

            }
            return results;
        }
    }
}
