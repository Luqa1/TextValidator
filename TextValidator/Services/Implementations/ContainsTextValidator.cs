using TextValidator.Services.Abstracts;
using TextValidator.Services.Implementations.Base;

namespace TextValidator.Services.Implementations
{
    class ContainsTextValidator : SepcializedTextValidatorBase, ISepcializedTextValidator
    {
        public override bool DoValidation(string text, string valueToCheck) =>
            text.Contains(valueToCheck);
    }
}
