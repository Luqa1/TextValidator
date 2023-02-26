using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using TextValidator.Model;
using TextValidator.Services.Abstracts;

namespace TextValidator.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {
        private ITextValidator _textValidator;
        private IValidationResultConverter _validationResultConverter;

        private ValidationModel _model;

        private ICommand _validateCommand;

        public MainWindowViewModel()
            : base()
        {
            Model = new ValidationModel();
            Model.Condition = SupportedConditions.FirstOrDefault();
        }

        public ITextValidator TextValidator 
        { 
            get => _textValidator;
            set
            {
                _textValidator = value;
            }
        }

        public IValidationResultConverter ValidationResultConverter
        {
            get => _validationResultConverter;
            set
            {
                _validationResultConverter = value;
            }
        }

        public ValidationModel Model
        {
            get { return _model; }
            set
            {
                if (value != _model)
                {
                    _model = value;
                    RaisePropertyChanged("Model");
                }
            }
        }

        public IReadOnlyList<string> SupportedConditions =>
            ConditionTypeHelper.GetAllConditions().ToList();

        public ICommand ValidateCommand
        {
            get
            {
                if (_validateCommand == null)
                    _validateCommand = new RelayCommand(() => Validate());

                return _validateCommand;
            }
        }

        private void Validate()
        {
            var condition = (ConditionType)Enum.Parse(typeof(ConditionType), Model.Condition);
            var validationResult = _textValidator.Validate(Model.Text, condition, Model.Pattern, Model.ShouldMatchCase);
            Model.ValidationResult = _validationResultConverter.GetViewValue(validationResult);
        }
    }
}
