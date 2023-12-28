using ATTicket.Application.Features.CompanyFeatures.TicketSurvey.Commands.Create;
using ATTicket.Domain.CompanyEntities;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface ITicketSurveyService
    {
        Task<IList<TicketSurvey>> GetAllAsync(string companyId);
        Task<TicketSurvey> GetByIdAsync(string id, string companyId);
        Task<TicketSurvey> CreateTicketSurveyAsync(CreateTicketSurveyCommand request, CancellationToken cancellationToken);
        Task<TicketSurvey> RemoveByIdTicketSurveyAsync(string id, string companyId);
        Task UpdateAsync(TicketSurvey ticketSurvey, string companyId);
    }
}
