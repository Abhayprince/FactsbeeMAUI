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

	private async void ToolbarCategory_Clicked(object sender, EventArgs e)
	{
		var parameters = new Dictionary<string, object> { ["categoryName"] = _viewModel.Fact.CategoryName };
        await Shell.Current.GoToAsync(nameof(CategoryFactsPage), parameters);
    }

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
		_viewModel.StopSpeaking();
	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
		_viewModel.InitializeTokenSource();
	}
}