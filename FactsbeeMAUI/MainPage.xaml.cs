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
}

