using Microsoft.AspNetCore.Mvc;
using prjTravelDate_core.Models;
using prjTravelDate_core.ViewModels;
using PagedList.Mvc;
using PagedList;

namespace prjTravelDate_core.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult SearchList(CKeywordViewModel keyword,int? page)
        {
            CFilteredProductFactory products = new CFilteredProductFactory();
            CSearchListViewModel vm = new CSearchListViewModel();
            
            vm.filterProducts = products.qureyFilterProductsInfo();//商品cards;
            if (!string.IsNullOrEmpty(keyword.txtKeyword))
            {
                vm.filterProducts = products.qureyFilterProductsInfo().Where(p => p.productName.Contains(keyword.txtKeyword)).ToList();
            }
            vm.categoryAndTags = products.qureyFilterCategories();//商品類別&標籤,左邊篩選列
            vm.countryAndCities = products.qureyFilterCountry();  //商品國家&縣市,左邊篩選列
            vm.types = products.qureyFilterTypes();//商品類型,左邊篩選列

            int pageSize = 10;
            int pageNumber = page ?? 1;
            vm.pages = vm.filterProducts.ToPagedList(pageNumber, pageSize);

            return View(vm);
        }
    }
}
