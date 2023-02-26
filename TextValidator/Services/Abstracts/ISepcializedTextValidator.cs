namespace TextValidator.Services.Abstracts
{
    interface ISepcializedTextValidator
    {
        bool Validate(string text, string valueToCheck, bool matchCase);
    }
}
