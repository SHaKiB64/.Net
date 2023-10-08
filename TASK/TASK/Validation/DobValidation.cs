using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TASK.Validation
{
    public class DobValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime input = (DateTime) value;
                int age = DateTime.Now.Year - input.Year;

                if (age < 18)
                {
                    return new ValidationResult($"You must be at least 18 years old.");
                }
            }
            return ValidationResult.Success;
        }
    }
}