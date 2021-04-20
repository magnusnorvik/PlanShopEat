using System;
using System.Linq;
using System.Threading.Tasks;

using PlanShopEat.Core.Models;
using PlanShopEat.Core.Services;
using PlanShopEat.Helpers;

namespace PlanShopEat.ViewModels
{
    public class RecipesDetailViewModel : Observable
    {
        private SampleOrder _item;

        public SampleOrder Item
        {
            get { return _item; }
            set { Set(ref _item, value); }
        }

        public RecipesDetailViewModel()
        {
        }

        public async Task InitializeAsync(long orderID)
        {
            var data = await SampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }
}
