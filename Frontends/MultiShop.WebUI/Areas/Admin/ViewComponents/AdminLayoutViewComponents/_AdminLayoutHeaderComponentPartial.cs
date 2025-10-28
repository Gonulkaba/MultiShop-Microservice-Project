using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MultiShop.WebUI.Services.CommentServices;
using MultiShop.WebUI.Services.Interfaces;
using MultiShop.WebUI.Services.MessageServices;
using MultiShop.WebUI.Services.StatisticServices.CommentStatisticServices;
using MultiShop.WebUI.Settings;

namespace MultiShop.WebUI.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutHeaderComponentPartial:ViewComponent
    {
        private readonly IMessageService _messageService;
        private readonly IUserService _userService;
        private readonly ICommentStatisticService _commentStatisticService;
        private readonly IOptions<ServiceApiSettings> _serviceApiSettings;

        public _AdminLayoutHeaderComponentPartial(
            IMessageService messageService,
            IUserService userService,
            ICommentStatisticService commentStatisticService,
            IOptions<ServiceApiSettings> serviceApiSettings)
        {
            _messageService = messageService;
            _userService = userService;
            _commentStatisticService = commentStatisticService;
            _serviceApiSettings = serviceApiSettings;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userService.GetUserInfo();
            ViewBag.UserId = user?.Id;
            //int messageCount = await _messageService.GetTotalMessageCountByReceiverId(user.Id);
            //int totalCommentCount = await _commentStatisticService.GetTotalCommentCount();

            //ViewBag.MessageCount = messageCount;
            //ViewBag.CommentCount = totalCommentCount;

            // SignalR mikroservis adresini ViewBag’e gönder
            ViewBag.SignalRUrl = _serviceApiSettings.Value.SignalRUrl;

            return View();
        }
    }
}
