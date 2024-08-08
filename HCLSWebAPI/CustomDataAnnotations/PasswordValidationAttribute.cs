using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace HCLSWebAPI.CustomDataAnnotations
{
    public class PasswordValidationAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string fieldValue = value as string;

            if (fieldValue.Length < 10)
            {
                return new ValidationResult("Password should have at least 10 characters", new[] { validationContext.MemberName });
            }

            if (!Regex.IsMatch(fieldValue, @"[A-Z]"))
            {
                return new ValidationResult("Password should contain at least one uppercase letter", new[] { validationContext.MemberName });
            }

            if (!Regex.IsMatch(fieldValue, @"[a-z]"))
            {
                return new ValidationResult("Password should contain at least one lowercase letter", new[] { validationContext.MemberName });
            }

            if (!Regex.IsMatch(fieldValue, @"[@#$%^&+=]"))
            {
                return new ValidationResult("Password should contain at least one special character", new[] { validationContext.MemberName });
            }

            return ValidationResult.Success;
        }

    }
}
