using FactsbeeMAUI.ViewModels;

namespace FactsbeeMAUI;

public partial class MainPage : ContentPage
{
	private readonly MainViewModel _viewModel;

	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;

		BindingContext = viewModel;
	}

	private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		await Shell.Current.DisplayAlert("Hi", "Hello, this is tapped from the category", "Ok");
	}
}

