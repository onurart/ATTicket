using ATTicket.Application.Services.AppService;
using ATTicket.Domain.AppEntities;
namespace ATTicket.Application.Features.AppFeatures.CompanyFeatures.Commands.UpdateCompany;
public sealed class UpdateCompanyCommandHandler : ICommandHandler<UpdateCompanyCommand, UpdateCompanyCommandResponse>
{
    private readonly ICompanyService _companyService;
    public UpdateCompanyCommandHandler(ICompanyService companyService)
    {
        _companyService = companyService;
    }
    public async Task<UpdateCompanyCommandResponse> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
    {
        //Company company = await _companyService.GetCompanyByName(request.Name, cancellationToken);
        //if (company != null) throw new Exception("Bu şirket adı daha önce kullanılmış!");

        Company companies = await _companyService.GetByIdAsync(request.Id);
        if (companies == null) throw new Exception("Şirket Bulunamadı!");
        companies.Id = request.Id;
        companies.Name = request.Name;
        companies.Address = request.Address;
        companies.IdentityNumber = request.IdentityNumber;
        companies.TaxDepartment = request.TaxDepartment;
        companies.Tel = request.Tel;
        companies.Email = request.Email;
        companies.ServerName = request.ServerName;
        companies.DatabaseName = request.DatabaseName;
        companies.ServerUserId = request.ServerUserId;
        companies.ServerPassword = request.ServerPassword;
        companies.ClientApiUrl = request.ClientApiUrl;
        companies.CompanyLogo = request.CompanyLogo;
        await _companyService.UpdateCompany(companies, cancellationToken);
        return new();
    }
}