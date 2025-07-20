using BMI.ViewModels;
using BMI.Views;

namespace BMI
{
    public partial class App : Application
    {
        private readonly BMIViewModel viewModel;

        public App(BMIViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new BMIView(viewModel));
        }
    }
}