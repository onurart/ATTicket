using ATTicket.Domain.AppEntities;
namespace ATTicket.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompany;
public sealed record GetAllCompanyQueryResponse(List<Company> Companies);