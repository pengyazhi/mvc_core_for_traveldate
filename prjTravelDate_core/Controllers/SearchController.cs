using Microsoft.AspNetCore.Mvc;
using prjTravelDate_core.Models;
using prjTravelDate_core.ViewModels;

namespace prjTravelDate_core.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult SearchList()
        {
            CFilteredProductFactory products = new CFilteredProductFactory();
            CSearchListViewModel vm = new CSearchListViewModel();
            vm.filterProducts = products.qureyFilterProductsInfo();//商品cards
           vm.categoryAndTags = products.qureyFilterCategories();//商品類別&標籤,左邊篩選列
            vm.countryAndCities = products.qureyFilterCountry();  //商品國家&縣市,左邊篩選列
            vm.types = products.qureyFilterTypes();//商品類型,左邊篩選列

            return View(vm);
        }
    }
}
