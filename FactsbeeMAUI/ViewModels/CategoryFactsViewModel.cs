using FactsbeeMAUI.Data;
using System.Collections.ObjectModel;

namespace FactsbeeMAUI.ViewModels
{
    [QueryProperty(nameof(CategoryName), nameof(categoryName))]
    public partial class CategoryFactsViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Title))]
        private string categoryName;

        public string Title => $"{CategoryName} Facts";

        public CategoryFactsViewModel()
        {

        }

        [ObservableProperty]
        private ObservableCollection<FactModel> _categoryFacts;

        public void LoadFacts()
        {
            var categoryFacts = FactsData.GetCategoryFacts(CategoryName);
            CategoryFacts = new ObservableCollection<FactModel>(categoryFacts);
        }

        [RelayCommand]
        private async Task GoToFactDetailsPage(FactModel fact)
        {
            await Shell.Current.GoToAsync(nameof(FactDetailsPage), new Dictionary<string, object> { [nameof(FactDetailViewModel.Fact)] = fact });
        }
    }
}
