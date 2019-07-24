using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sTreeHw0706.Model.Attributes
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
