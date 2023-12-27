using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.CompanyFeatures.Commands.UpdatePhotoCompany;
public sealed record UpdatePhotoCompanyCommand(string id, string companylogo) : ICommand<UpdatePhotoCompanyCommandResponse>;
