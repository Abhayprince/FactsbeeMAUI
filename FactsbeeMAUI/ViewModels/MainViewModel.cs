using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FactsbeeMAUI.Data;
using FactsbeeMAUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactsbeeMAUI.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private FactModel _factOfTheDay;

        public IEnumerable<CategoryModel> Categories { get; set; }
        public IEnumerable<FactModel> RandomFacts { get; set; }

        public MainViewModel()
        {
            Categories = CategoryModel.GetCategories();

            FactOfTheDay = FactsData.GetFactOfTheDay();

            RandomFacts = FactsData.GetRandomFacts();            
        }

        [RelayCommand]
        private async Task GoToCategoryPage(string categoryName)
        {
            //await Shell.Current.GoToAsync($"{nameof(CategoryFactsPage)}?categoryName={categoryName}");
            
            await Shell.Current.GoToAsync(nameof(CategoryFactsPage), new Dictionary<string, object> { ["categoryName"] = categoryName });
        }

        [RelayCommand]
        private async Task GoToFactDetailsPage(FactModel fact)
        {
            await Shell.Current.GoToAsync(nameof(FactDetailsPage), new Dictionary<string, object> { [nameof(FactDetailViewModel.Fact)] = fact });
        }
    }
}
