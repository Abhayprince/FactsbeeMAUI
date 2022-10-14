namespace FactsbeeMAUI.Pages;

public partial class FactDetailsPage : ContentPage
{
	private readonly FactDetailViewModel _viewModel;

	public FactDetailsPage(FactDetailViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;

		BindingContext = viewModel;
	}
}