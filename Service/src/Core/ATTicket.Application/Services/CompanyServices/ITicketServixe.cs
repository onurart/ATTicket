using ATTicket.Application.Features.CompanyFeatures.Ticket.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface ITicketServixe
    {
        Task<IList<Ticket>> GetAllAsync(string companyId);
        Task<Ticket> GetByIdAsync(string id, string companyId);
        Task<Ticket> CreateTicketAsync(CreateTicketCommand request, CancellationToken cancellationToken);
        Task<Ticket> RemoveByIdTicketAsync(string id, string companyId);
        Task UpdateAsync(Ticket ticket, string companyId);
    }
}
