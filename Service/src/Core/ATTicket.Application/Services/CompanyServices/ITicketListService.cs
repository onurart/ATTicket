using ATTicket.Application.Features.CompanyFeatures.TicketList.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface ITicketListService
    {
        Task<IList<TicketList>> GetAllAsync(string companyId);
        Task<TicketList> GetByIdAsync(string id, string companyId);
        Task<TicketList> CreateTicketListAsync(CreateTicketListCommand request, CancellationToken cancellationToken);
        Task<TicketList> RemoveByIdTicketListAsync(string id, string companyId);
        Task UpdateAsync(TicketList ticketList, string companyId);
    }
}
