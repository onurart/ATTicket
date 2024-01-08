using ATTicket.Application.Features.CompanyFeatures.TicketPdfDetail.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface ITicketPdfDetailService
    {
        Task<IList<TicketPdfDetail>> GetAllAsync(string companyId);
        Task<TicketPdfDetail> GetByIdAsync(string id, string companyId);
        Task<TicketPdfDetail> CreateTicketPdfDetailAsync(CreateTicketPdfDetailCommand request, CancellationToken cancellationToken);
        Task<TicketPdfDetail> RemoveByIdTicketPdfDetailAsync(string id, string companyId);
        Task UpdateAsync(TicketPdfDetail ticketPdfDetail, string companyId);
    }
}
