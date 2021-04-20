using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace API.SignalR
{
    public class MessagingCenter : Hub
    {
        private readonly IMediator _mediator;

        public MessagingCenter(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task SendMessage()
        {
            var message = await _mediator.Send(command);
            
            await 
        }
    }
}