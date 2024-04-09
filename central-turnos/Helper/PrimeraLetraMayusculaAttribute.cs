using System.ComponentModel.DataAnnotations;

namespace central_turnos.Helper;

public class PrimeraLetraMayusculaAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object value, ValidationContext validationContext)
    {
        if (value == null || string.IsNullOrEmpty(value.ToString()))
        {
            return ValidationResult.Success;
        }
        var primeraLetra = value.ToString()[0].ToString();

        return primeraLetra != primeraLetra.ToUpper()
            ? new ValidationResult("La primer letra debe estar en mayúscula")
            : ValidationResult.Success;
    }
}
