using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TASK.Validation;

namespace TASK.Models
{
    public class Signup
    {
        [Required(ErrorMessage = "Provide your name")]
        [RegularExpression("^[a-zA-Z]{4,50}$", ErrorMessage = "Only alphabetic characters are allowed, and the length should be between 4 and 50 characters.")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Provide your User ID")]
        [RegularExpression("^[A-Za-z0-9\\-_]{4,12}$", ErrorMessage = "Only alphabetic characters, numbers, and dashes are allowed, and the length should be between 4 and 12 characters.")]
        public string UserId { get; set; }
        
        [Required(ErrorMessage = "Provide your Password")]
        [StringLength(32, ErrorMessage = "Length <32")]
        [RegularExpression("^(?=.*[A-Z])(?=.*[a-z].*[a-z])(?=.*[!@#$%^&*0-9].*[!@#$%^&*0-9])[A-Za-z]{4}[!@#$%^&*0-9]{4,}[A-Za-z0-9\\-!@#$%^&*]{0,}$",
        ErrorMessage = "The string must have a minimum length of 8. The first 4 characters must be alphabetic (with at least 1 uppercase and 2 lowercase), and the next 4 characters must be a combination of special characters and numbers.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Provide your ID")]
        [IdPattern(ErrorMessage = "Invaid ID.")]
        public string ID { get; set; }

        [Required(ErrorMessage = "Provide your Email")]
        [EmPattern(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Provide your DOB")]
        [DobValidation(ErrorMessage = "Date of Birth should be greater than 18 !")]
        public DateTime Dob { get; set; }



    }
}