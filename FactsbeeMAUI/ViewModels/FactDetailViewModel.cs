using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using FactsbeeMAUI.Data;

namespace FactsbeeMAUI.ViewModels
{

    [QueryProperty(nameof(Fact), nameof(Fact))]
    [QueryProperty(nameof(Category), nameof(Category))]
    public partial class FactDetailViewModel : ObservableObject
    {
        private readonly ITextToSpeech _textToSpeech;

        [ObservableProperty]
        private FactModel _fact;

        [ObservableProperty]
        private string _category;

        private CancellationTokenSource _cancellationTokenSource;

        public FactDetailViewModel(ITextToSpeech textToSpeech)
        {
            _textToSpeech = textToSpeech;
            InitializeTokenSource();
        }

        public void InitializeTokenSource()
        {
            if(_cancellationTokenSource is null || _cancellationTokenSource.IsCancellationRequested)
                _cancellationTokenSource = new();
        }

        [RelayCommand]
        private async Task SpeakFactAsync()
        {
            if (!_cancellationTokenSource.IsCancellationRequested)
            {
                await _textToSpeech.SpeakAsync(Fact.Fact, new SpeechOptions
                {
                    Pitch = 1
                },
                _cancellationTokenSource.Token);
            }
        }

        [RelayCommand]
        private async Task CopyFactAsync()
        {
            var copiedText = $"{Fact.Fact} - {Fact.CategoryName} | Factsbee by Abhay Prince";
            await Clipboard.Default.SetTextAsync(copiedText);

            //await Shell.Current.DisplayAlert("Fact Copied", copiedText, "OK");

            //var toastDuration = ToastDuration.Long;
            //var fontSize = 24;
            //var toast = Toast.Make(copiedText, toastDuration, fontSize);

            var toast = Toast.Make(copiedText);
            await toast.Show();
        }

        [RelayCommand]
        private async Task ShareFactAsync()
        {
            var title = "Factsbee by Abhay Prince";
            var textToShare = $"{Fact.Fact} - {Fact.CategoryName}";

            await Share.RequestAsync(textToShare, title);
        }

        [RelayCommand]
        private async Task GetPrevFactAsync()
        {
            var prevFact = FactsData.GetPrevFact(Fact.Id, Category ?? Fact.CategoryName);
            if (prevFact is null)
            {
                await Shell.Current.DisplayAlert("Alert", "There is no previous fact.", "Ok");
            }
            else
            {
                Fact = prevFact;
            }
        }

        [RelayCommand]
        private async Task GetNextFactAsync()
        {
            var nextFact = FactsData.GetNextFact(Fact.Id, Category ?? Fact.CategoryName);
            if (nextFact is null)
            {
                await Shell.Current.DisplayAlert("Alert", "There is no next fact.", "Ok");
            }
            else
            {
                Fact = nextFact;
            }
        }

        public void StopSpeaking() => _cancellationTokenSource?.Cancel();
    }
}
