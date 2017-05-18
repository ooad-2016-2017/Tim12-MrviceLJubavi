using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasajBA.Helper
{
    class PunoljetstvoPropertyAttribute : ValidationAttribute
    {
        public PunoljetstvoPropertyAttribute () { }
        protected override ValidationResult IsValid (object value, ValidationContext obj)
        {
            if (value==null)
            {
                return new ValidationResult(this.ErrorMessage);
            }
            if (DateTime.Now.AddYears(-18)<(DateTime)value)
            {
                return new ValidationResult(this.ErrorMessage);
            }
            return ValidationResult.Success;
        }
    }
}
