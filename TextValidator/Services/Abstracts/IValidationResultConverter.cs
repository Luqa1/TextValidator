namespace TextValidator.Services.Abstracts
{
    public interface IValidationResultConverter
    {
        string GetViewValue(bool validationResult);
    }
}
