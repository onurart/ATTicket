using ATTicket.Application.Features.CompanyFeatures.TicketSolution.Commands.Create;
using ATTicket.Domain.CompanyEntities;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface ITicketSolutionService
    {
        Task<IList<TicketSolution>> GetAllAsync(string companyId);
        Task<TicketSolution> GetByIdAsync(string id, string companyId);
        Task<TicketSolution> CreateTicketSolutionAsync(CreateTicketSolutionCommand request, CancellationToken cancellationToken);
        Task<TicketSolution> RemoveByIdTicketSolutionAsync(string id, string companyId);
        Task UpdateAsync(TicketSolution ticketSolution, string companyId);
    }
}
