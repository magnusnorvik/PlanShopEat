using System;

using PlanShopEat.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace PlanShopEat.Views
{
    public sealed partial class RecipesPage : Page
    {
        public RecipesViewModel ViewModel { get; } = new RecipesViewModel();

        public RecipesPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await ViewModel.LoadDataAsync();
        }
    }
}
