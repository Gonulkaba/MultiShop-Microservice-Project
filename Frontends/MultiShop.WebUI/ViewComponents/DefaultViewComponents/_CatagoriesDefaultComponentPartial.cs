using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.CategoryDtos;
using MultiShop.WebUI.Services.CatalogServices.CategoryServices;
using MultiShop.WebUI.Services.CatalogServices.ProductServices;
using Newtonsoft.Json;
namespace MultiShop.WebUI.ViewComponents.DefaultViewComponents
{
    public class _CatagoriesDefaultComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public _CatagoriesDefaultComponentPartial(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetAllCategoryAsync();
            // Her kategoriye ait ürün sayısını çek
            foreach (var category in values)
            {
                var products = await _productService.GetProductsWithCategoryByCategoryIdAsync(category.CategoryId);
                category.ProductCount = products.Count();
            }
            return View(values);
        }
    }
}
