using System.ComponentModel.DataAnnotations;

namespace ExemploValidacaoModel.Validations
{
    public class MinValueAtrribute : ValidationAttribute
    {
        private readonly int _minValue;

        public MinValueAtrribute(int minValue)
        {
            _minValue = minValue;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var valueAsInt = (int)value;
                if (valueAsInt < _minValue)
                {
                    return new ValidationResult($"{validationContext.DisplayName}: deve ser maior que {_minValue}");
                }
            }

            return ValidationResult.Success;
        }
    }
}
