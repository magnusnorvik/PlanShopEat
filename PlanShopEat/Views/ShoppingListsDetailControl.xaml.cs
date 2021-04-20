using System;

using PlanShopEat.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PlanShopEat.Views
{
    public sealed partial class ShoppingListsDetailControl : UserControl
    {
        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(ShoppingListsDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public ShoppingListsDetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ShoppingListsDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
