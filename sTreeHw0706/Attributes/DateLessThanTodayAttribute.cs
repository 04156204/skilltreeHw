using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace sTreeHw0706.Helper
{
    public class DateLessThanTodayAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if (DateTime.Parse(value.ToString()) > DateTime.Now)
                {
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                }
                else { return ValidationResult.Success; }
            }

            return null;
        }
    }
}