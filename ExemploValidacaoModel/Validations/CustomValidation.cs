using System.ComponentModel.DataAnnotations;

namespace ExemploValidacaoModel.Validations
{
    public class CustomValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                bool? valueAsBool = (bool?)value;
                return valueAsBool.Value;
            }

            return false;
        }
    }
}
