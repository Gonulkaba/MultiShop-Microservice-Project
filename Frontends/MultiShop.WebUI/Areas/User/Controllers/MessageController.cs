using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.Interfaces;
using MultiShop.WebUI.Services.MessageServices;

namespace MultiShop.WebUI.Areas.User.Controllers
{
    [Area("User")]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly IUserService _userService;
        public MessageController(IMessageService messageService, IUserService userService)
        {
            _messageService = messageService;
            _userService = userService;
        }

        public async Task<IActionResult> Inbox()
        {
            var user = await _userService.GetUserInfo();
            var values = await _messageService.GetInboxMessageAsync(user.Id);
            return View(values);
        }

        public async Task<IActionResult> Sendbox()
        {
            var user = await _userService.GetUserInfo();
            var values = await _messageService.GetSendboxMessageAsync(user.Id);
            return View(values);
        }

        // GET: /User/Message/MessageDetail/123?type=inbox veya type=sendbox
        [HttpGet]
        public async Task<IActionResult> MessageDetail(int id, string type)
        {
            var message = await _messageService.GetByIdMessageAsync(id);
            if (message == null)
                return NotFound();

            ViewBag.MessageType = type;

            return View(message);
        }
    }
}
