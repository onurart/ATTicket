using ATTicket.Application.Features.CompanyFeatures.TicketStatu.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface ITicketStatuService
    {
        Task<IList<TicketStatu>> GetAllAsync(string companyId);
        Task<TicketStatu> GetByIdAsync(string id, string companyId);
        Task<TicketStatu> CreateTicketStatuAsync(CreateTicketStatuStatu request, CancellationToken cancellationToken);
        Task<TicketStatu> RemoveByIdTicketStatuAsync(string id, string companyId);
        Task UpdateAsync(TicketStatu ticketStatu, string companyId);
    }
}
