using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.Areas.User.Controllers
{
    [Area("User")]
    public class LogOutController : Controller
    {
        public async Task<IActionResult> Index()
        {
            // Kullanıcının cookie bilgisini silerek çıkış yapar
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login", new { area = "" });
        }
    }
}
