using Autofac;
using System.Windows;
using TextValidator.ViewModel;

namespace TextValidator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<TextValidatorModule>();
            var container = builder.Build();

            InitializeComponent();

            DataContext = container.Resolve<MainWindowViewModel>();
        }
    }
}
