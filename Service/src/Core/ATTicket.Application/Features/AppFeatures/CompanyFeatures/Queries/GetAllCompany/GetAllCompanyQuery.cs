using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.CompanyFeatures.Queries.GetAllCompany;
public sealed record GetAllCompanyQuery() : IQuery<GetAllCompanyQueryResponse>;