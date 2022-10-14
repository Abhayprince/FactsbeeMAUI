

namespace FactsbeeMAUI.Pages;

public partial class CategoryFactsPage : ContentPage
{
	private readonly CategoryFactsViewModel _viewModel;
	public CategoryFactsPage(CategoryFactsViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
		_viewModel = viewModel;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		_viewModel.LoadFacts();
	}
}