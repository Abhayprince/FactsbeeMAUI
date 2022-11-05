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

            FactOfTheDay = GetFactOfTheDay();

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
            var parameters = new Dictionary<string, object> { 
                [nameof(FactDetailViewModel.Fact)] = fact,
                [nameof(FactDetailViewModel.Category)] = CategoryModel.Random
            };
            await Shell.Current.GoToAsync(nameof(FactDetailsPage), parameters);
        }

        private static string GetFotdKey(DateTime dateTime) => $"fotd_{dateTime}";

        // Not Working as Expected in Part 4 of the Video
        // We will fix it in Next Part
        private FactModel GetFactOfTheDay()
        {
            var key = GetFotdKey(DateTime.Today);
            FactModel fotd = null;
            if (Preferences.Default.ContainsKey(key))
            {
                fotd = Preferences.Default.Get<FactModel>(key, null);
            }
            else
            {
                fotd = FactsData.GetFactOfTheDay();
                Preferences.Default.Set<FactModel>(key, fotd);
            }
            return fotd;
        }
    }
}
