using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.IdentityDtos.LoginDtos;
using MultiShop.WebUI.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using MultiShop.WebUI.Services;
using MultiShop.WebUI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace MultiShop.WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		private readonly IIdentityService _identityService;

        public LoginController(IHttpClientFactory httpClientFactory, IIdentityService identityService)
        {
            _httpClientFactory = httpClientFactory;
            _identityService = identityService;
        }
        [HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(SignInDto signInDto)
		{
            /*
			var client = _httpClientFactory.CreateClient();
			var content = new StringContent(JsonSerializer.Serialize(createLoginDto), Encoding.UTF8, "application/json");
			var response = await client.PostAsync("http://localhost:5001/api/Logins",content);
			if (response.IsSuccessStatusCode)
			{
				var jsonData = await response.Content.ReadAsStringAsync();
				var tokenModel = JsonSerializer.Deserialize<JwtResponseModel>(jsonData, new JsonSerializerOptions
				{
					PropertyNamingPolicy = JsonNamingPolicy.CamelCase
				});
				if (tokenModel !=null)
				{
					JwtSecurityTokenHandler handler= new JwtSecurityTokenHandler();
					var token = handler.ReadJwtToken(tokenModel.Token);
					var claims=token.Claims.ToList();

					if (tokenModel.Token != null)
					{
						claims.Add(new Claim("multishoptoken", tokenModel.Token));
						var claimsIdentity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);
						var authProps = new AuthenticationProperties
						{
							ExpiresUtc = tokenModel.ExpireDate,
							IsPersistent = true
						};
						await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProps);
						var id = _loginService.GetUserId;
						return RedirectToAction("Index", "Default");
					}
				}
			}
			*/

            await _identityService.SignIn(signInDto);
            return RedirectToAction("Index", "Default");
		}

		//Pasif metot
        //[HttpPost]
        public async Task<IActionResult> SignIn(SignInDto signInDto)
        {
            signInDto.UserName = "ali02";
            signInDto.Password = "1234.aA*";
            await _identityService.SignIn(signInDto);
            return RedirectToAction("Index", "User");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
