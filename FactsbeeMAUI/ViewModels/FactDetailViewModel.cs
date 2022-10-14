namespace FactsbeeMAUI.ViewModels
{

    [QueryProperty(nameof(Fact), nameof(Fact))]
    public partial class FactDetailViewModel : ObservableObject
    {
        private readonly ITextToSpeech _textToSpeech;
        [ObservableProperty]
        private FactModel _fact;

        public FactDetailViewModel(ITextToSpeech textToSpeech)
        {
            _textToSpeech = textToSpeech;
        }

        [RelayCommand]
        private async Task SpeakFactAsync()
        {
            await _textToSpeech.SpeakAsync(Fact.Fact, new SpeechOptions
            {
                Pitch = 1
            });
        }

        [RelayCommand]
        private async Task CopyFactAsync()
        {
            await Clipboard.Default.SetTextAsync($"{Fact.Fact} - {Fact.CategoryName} | Factsbee by Abhay Prince");
        }
    }
}
