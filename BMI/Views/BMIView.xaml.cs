using BMI.ViewModels;

namespace BMI.Views;

public partial class BMIView : ContentPage
{
	public BMIView(BMIViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}