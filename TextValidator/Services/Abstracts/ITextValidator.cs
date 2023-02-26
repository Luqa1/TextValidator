using TextValidator.Model;

namespace TextValidator.Services.Abstracts
{
    public interface ITextValidator
    {
        bool Validate(string text, ConditionType conditionType, string valueToCheck, bool matchCase);
    }
}
