using ATTicket.Application.Features.CompanyFeatures.TicketMail.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface ITicketMailService
    {
        Task<IList<TicketMail>> GetAllAsync(string companyId);
        Task<TicketMail> GetByIdAsync(string id, string companyId);
        Task<TicketMail> CreateTicketMailAsync(CreateTicketMailCommand request, CancellationToken cancellationToken);
        Task<TicketMail> RemoveByIdTicketMailAsync(string id, string companyId);
        Task UpdateAsync(TicketMail ticketMail, string companyId);
    }
}
