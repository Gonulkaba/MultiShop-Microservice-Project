using Microsoft.AspNetCore.SignalR;
using MultiShop.SignalRRealTimeApi.Services.SignalRCommentServices;
using MultiShop.SignalRRealTimeApi.Services.SignalRMessageServices;

namespace MultiShop.SignalRRealTimeApi.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ISignalRCommentService _signalRCommentService;
        private readonly ISignalRMessageService _signalRMessageService;

        public SignalRHub(ISignalRCommentService signalRCommentService, ISignalRMessageService signalRMessageService)
        {
            _signalRCommentService = signalRCommentService;
            _signalRMessageService = signalRMessageService;
        }

        public async Task SendStatisticCount(string id)
        {
            var getTotalCommentCount = await _signalRCommentService.GetTotalCommentCount();
            await Clients.All.SendAsync("ReceiveCommentCount", getTotalCommentCount);

            try
            {
                var getTotalMessageCount = 0;
                if (!string.IsNullOrEmpty(id))
                {
                    getTotalMessageCount = await _signalRMessageService.GetTotalMessageCountByReceiverId(id);
                }
                await Clients.All.SendAsync("ReceiveMessageCount", getTotalMessageCount);
            }
            catch (Exception ex)
            {
                await Clients.All.SendAsync("ReceiveMessageCount", 0);
            }
        }

        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
        }
    }
}
