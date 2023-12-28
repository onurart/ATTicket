using ATTicket.Application.Features.CompanyFeatures.TicketLine.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface ITicketLineService
    {
        Task<IList<TicketLine>> GetAllAsync(string companyId);
        Task<TicketLine> GetByIdAsync(string id, string companyId);
        Task<TicketLine> CreateTicketLineAsync(CreateTicketLineCommand request, CancellationToken cancellationToken);
        Task<TicketLine> RemoveByIdTicketLineAsync(string id, string companyId);
        Task UpdateAsync(TicketLine ticketLine, string companyId);
    }
}
