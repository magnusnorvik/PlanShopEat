using System;

using PlanShopEat.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PlanShopEat.Views
{
    public sealed partial class ShoppingListsPage : Page
    {
        public ShoppingListsViewModel ViewModel { get; } = new ShoppingListsViewModel();

        public ShoppingListsPage()
        {
            InitializeComponent();
            Loaded += ShoppingListsPage_Loaded;
        }

        private async void ShoppingListsPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(MasterDetailsViewControl.ViewState);
        }
    }
}
