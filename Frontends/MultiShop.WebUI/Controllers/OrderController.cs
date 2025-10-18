using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.OrderDtos.OrderAddressDtos;
using MultiShop.WebUI.Services.BasketServices;
using MultiShop.WebUI.Services.Interfaces;
using MultiShop.WebUI.Services.OrderServices.OrderAddressServices;

namespace MultiShop.WebUI.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderAddressService _orderAddressService;
        private readonly IUserService _userService;
        private readonly IBasketService _basketService;

        public OrderController(IOrderAddressService orderAddressService, IUserService userService, IBasketService basketService)
        {
            _orderAddressService = orderAddressService;
            _userService = userService;
            _basketService = basketService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.directory1 = "MultiShop";
            ViewBag.directory2 = "Siparişler";
            ViewBag.directory3 = "Sipariş İşlemleri";
            
            decimal shipping =20;
            ViewBag.Shipping = shipping;

            var values = await _basketService.GetBasket();
            var tax = values.TotalPrice / 100 * 10;
            var totalPriceWithTax = values.TotalPrice + tax;
            ViewBag.TotalPrice = totalPriceWithTax;
            ViewBag.GrandTotal = totalPriceWithTax + shipping;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateOrderAddressDto createOrderAddressDto)
        {
            var values = await _userService.GetUserInfo();
            createOrderAddressDto.UserId = values.Id;
            createOrderAddressDto.Description = "aa";
            await _orderAddressService.CreateOrderAddressAsync(createOrderAddressDto);

            return RedirectToAction("Index", "Payment");
        }
    }
}
