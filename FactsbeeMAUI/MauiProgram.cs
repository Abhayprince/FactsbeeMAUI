using CommunityToolkit.Maui;
using FactsbeeMAUI.ViewModels;

namespace FactsbeeMAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
            .UseMauiCommunityToolkit();

		builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddTransient<CategoryFactsViewModel>();
		builder.Services.AddTransient<FactDetailViewModel>();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<CategoryFactsPage>();
		builder.Services.AddTransient<FactDetailsPage>();

		builder.Services.AddSingleton<ITextToSpeech>(TextToSpeech.Default);

		return builder.Build();
	}
}
