using System.ComponentModel.DataAnnotations;

namespace FirstApp.CustomValidation
{
    public class ValidationEmail : ValidationAttribute
    {
        private readonly string allowedDomain;
        public ValidationEmail(string Domain)
        {
            allowedDomain = Domain;
        }

        public override bool IsValid(object? value)
        {
            string[] strings = value.ToString().Split('@');
            return strings[1].ToUpper() == allowedDomain.ToUpper();
        }
    }
}
