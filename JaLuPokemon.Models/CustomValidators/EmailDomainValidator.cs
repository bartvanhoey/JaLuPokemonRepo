using System.ComponentModel.DataAnnotations;

namespace JaLuPokemon.Models.CustomValidators
{
    public class EmailDomainValidator : ValidationAttribute
    {
        public string AllowedDomain { get; set; }
        public new string ErrorMessage { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string[] strings = value.ToString().Split('@');
            if (strings.Length > 1 && strings[1].ToUpper() == AllowedDomain.ToUpper())
            {
                return null;
            }
            else
            {
                var errorMessage = $"Domain Name must be {AllowedDomain}";
                if (!string.IsNullOrEmpty(ErrorMessage))
                {
                    errorMessage = ErrorMessage;
                }
                return new ValidationResult(errorMessage, new[] { validationContext.MemberName });
            }
        }
    }
}