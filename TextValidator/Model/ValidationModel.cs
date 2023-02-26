using GalaSoft.MvvmLight;

namespace TextValidator.Model
{
    public class ValidationModel : ObservableObject
    {
        #region Members

        private string _text;
        private string _pattern;
        private string _condition;
        private bool _shouldMatchCase;
        private string _validationResult;

        #endregion

        #region Properties

        public string Text
        {
            get { return _text; }
            set
            {
                if (value != _text)
                {
                    _text = value;
                    RaisePropertyChanged("Text");
                }
            }
        }

        public string Pattern
        {
            get { return _pattern; }
            set
            {
                if (value != _pattern)
                {
                    _pattern = value;
                    RaisePropertyChanged("Pattern");
                }
            }
        }

        public string Condition
        {
            get { return _condition; }
            set
            {
                if (value != _condition)
                {
                    _condition = value;
                    RaisePropertyChanged("Condition");
                }
            }
        }

        public bool ShouldMatchCase
        {
            get { return _shouldMatchCase; }
            set
            {
                if (value != _shouldMatchCase)
                {
                    _shouldMatchCase = value;
                    RaisePropertyChanged("ShouldMatchCase");
                }
            }
        }

        public string ValidationResult
        {
            get { return _validationResult; }
            set
            {
                if (value != _validationResult)
                {
                    _validationResult = value;
                    RaisePropertyChanged("ValidationResult");
                }
            }
        }

        #endregion
    }
}
