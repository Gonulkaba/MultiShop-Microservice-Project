namespace MultiShop.Basket.LoginServices
{
    public class LoginService : ILoginService
    {
        private readonly IHttpContextAccessor _httpcontextAccessor;

        public LoginService(IHttpContextAccessor httpcontextAccessor)
        {
            _httpcontextAccessor = httpcontextAccessor;
        }

        //Giriş yapan kullanıcının Id değerini alma işlemi
        public string GetUsreId => _httpcontextAccessor.HttpContext.User.FindFirst("sub").Value;
    }
}
