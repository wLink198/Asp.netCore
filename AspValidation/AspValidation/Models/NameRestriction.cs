using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspValidation.Models
{
    public class NameRestriction: ValidationAttribute
    {
        public NameRestriction()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Product product = (Product)validationContext.ObjectInstance;

            if (product.Name.Contains("sex") || product.Name.Contains("porn"))
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }

        private string GetErrorMessage()
        {
            return $"Name can not contain either 'sex' or 'porn'";
        }
    }
}
