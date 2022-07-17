using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetails
{
    public class GetEventDetailQuery : IRequest<EventDetaisViewModel>
    {
        public Guid Id { get; set; }
    }
}
