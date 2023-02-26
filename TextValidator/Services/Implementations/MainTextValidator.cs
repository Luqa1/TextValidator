using Autofac;
using TextValidator.Model;
using TextValidator.Services.Abstracts;

namespace TextValidator.Services.Implementations
{
    class MainTextValidator : ITextValidator
    {
        private readonly ILifetimeScope _lifetimeScope;

        public MainTextValidator(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public bool Validate(string text, ConditionType conditionType, string valueToCheck, bool matchCase)
        {
            var validator = _lifetimeScope.ResolveKeyed<ISepcializedTextValidator>(conditionType);
            return validator.Validate(text, valueToCheck, matchCase);
        }
    }
}
