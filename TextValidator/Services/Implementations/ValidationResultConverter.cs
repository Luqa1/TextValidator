using TextValidator.Services.Abstracts;

namespace TextValidator.Services.Implementations
{
    internal class ValidationResultConverter : IValidationResultConverter
    {
        public string GetViewValue(bool validationResult)
        {
            if (validationResult)
                return "Sukces";

            return "Brak dopasowania";
        }
    }
}
