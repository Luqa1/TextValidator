using Autofac;
using TextValidator.Model;
using TextValidator.Services.Abstracts;
using TextValidator.Services.Implementations;
using TextValidator.ViewModel;

namespace TextValidator
{
    class TextValidatorModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register((ctx) => 
            {
                var vm = new MainWindowViewModel();
                vm.TextValidator = ctx.Resolve<ITextValidator>();
                vm.ValidationResultConverter = ctx.Resolve<IValidationResultConverter>();
                return vm;
            }).As<MainWindowViewModel>();

            builder.RegisterType<ValidationResultConverter>().As<IValidationResultConverter>().InstancePerLifetimeScope();
            builder.RegisterType<MainTextValidator>().As<ITextValidator>().InstancePerLifetimeScope();
            builder.RegisterType<EqualsTextValidator>().Keyed<ISepcializedTextValidator>(ConditionType.EQUALS);
            builder.RegisterType<StartsWithTextValidator>().Keyed<ISepcializedTextValidator>(ConditionType.STARTS);
            builder.RegisterType<EndsWithTextValidator>().Keyed<ISepcializedTextValidator>(ConditionType.ENDS);
            builder.RegisterType<ContainsTextValidator>().Keyed<ISepcializedTextValidator>(ConditionType.CONTAINS);
        }
    }
}
