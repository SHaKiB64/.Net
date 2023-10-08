using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace TASK.Validation
{
    public class EmPattern : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string input = value.ToString();

                if (!Regex.IsMatch(input, @"^\d{2}-\d{5}-\d@student.aiub.edu$"))
                {
                    return new ValidationResult("The input must follow the pattern xx-xxxxx-x, and domain must 'student.aiub.edu'.");
                }
            }

            return ValidationResult.Success;
        }

    }
}