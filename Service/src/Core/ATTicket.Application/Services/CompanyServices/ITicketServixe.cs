using ATTicket.Application.Features.CompanyFeatures.Ticket.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface ITicketServixe
    {
        Task<IList<Tickets>> GetAllAsync(string companyId);
        Task<Tickets> GetByIdAsync(string id, string companyId);
        Task<Tickets> CreateTicketAsync(CreateTicketCommand request, CancellationToken cancellationToken);
        Task<Tickets> RemoveByIdTicketAsync(string id, string companyId);
        Task UpdateAsync(Tickets ticket, string companyId);
    }
}
