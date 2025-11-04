using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.CategoryDtos;
using MultiShop.WebUI.Services.BasketServices;
using MultiShop.WebUI.Services.CatalogServices.CategoryServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace MultiShop.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _NavbarUILayoutComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IBasketService _basketService;

        public _NavbarUILayoutComponentPartial(ICategoryService categoryService, IBasketService basketService)
        {
            _categoryService = categoryService;
            _basketService = basketService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetAllCategoryAsync();

            // sepetteki ürün sayısını al
            int basketCount = 0;
            try
            {
                var basket = await _basketService.GetBasket();
                if (basket != null && basket.BasketItems != null)
                    basketCount = basket.BasketItems.Sum(x => x.Quantity);
            }
            catch
            {
                // kullanıcı login değil -> sepet sayısı 0 olarak kalır
                basketCount = 0;
            }
            ViewBag.BasketCount = basketCount;

            return View(values);
        }
    }
}
