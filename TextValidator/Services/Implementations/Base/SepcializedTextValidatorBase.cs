using TextValidator.Services.Abstracts;

namespace TextValidator.Services.Implementations.Base
{
    abstract class SepcializedTextValidatorBase : ISepcializedTextValidator
    {
        public abstract bool DoValidation(string text, string valueToCheck);

        public bool Validate(string text, string valueToCheck, bool matchCase)
        {
            if (!matchCase)
            {
                text = text.ToLower();
                valueToCheck = valueToCheck.ToLower();
            }

            return DoValidation(text, valueToCheck);
        }
    }
}
