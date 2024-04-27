using System.ComponentModel.DataAnnotations;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class MustBeTrueAttribute : ValidationAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return "The " + name + " field must be checked in order to continue.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            }

            var boolValue = value as bool?;
            if (boolValue != null && boolValue == true)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        }
    }
}