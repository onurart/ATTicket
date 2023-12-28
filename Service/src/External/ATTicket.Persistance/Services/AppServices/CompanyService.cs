using ATTicket.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using ATTicket.Application.Services.AppService;
using ATTicket.Domain.AppEntities;
using ATTicket.Domain.Repositories.AppDbContext.CompanyRepositories;
using ATTicket.Domain.UnitOfWorks;
using ATTicket.Persistance.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace ATTicket.Persistance.Services.AppServices
{
    public sealed class CompanyService: ICompanyService
    {
        private readonly ICompanyCommandRepository _companyCommandRepository;
        private readonly ICompanyQueryRepository _companyQueryRepository;
        private readonly IAppUnitOfWork _appUnitOfWork;
        private readonly IMapper _mapper;
        public CompanyService(ICompanyCommandRepository companyCommandRepository, ICompanyQueryRepository companyQueryRepository, IAppUnitOfWork appUnitOfWork, IMapper mapper)
        {
            _companyCommandRepository = companyCommandRepository;
            _companyQueryRepository = companyQueryRepository;
            _appUnitOfWork = appUnitOfWork;
            _mapper = mapper;
        }
        public async Task CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            Company company = _mapper.Map<Company>(request);
            company.Id = Guid.NewGuid().ToString();
            company.DatabaseName = "ATTickets" + request.DatabaseName;
            await _companyCommandRepository.AddAsync(company, cancellationToken);
            await _appUnitOfWork.SaveChangesAsync(cancellationToken);
        }
        public IQueryable<Company> GetAll()
        {
            return _companyQueryRepository.GetAll();
        }
        public async Task<Company> GetByIdAsync(string id)
        {
            return await _companyQueryRepository.GetById(id);
        }
        public async Task<Company?> GetCompanyByName(string name, CancellationToken cancellationToken)
        {
            return await _companyQueryRepository.GetFirstByExpiression(x => x.Name == name, cancellationToken, false);
        }
        public async Task MigrateCompanyDatabases()
        {
            var compaies = await _companyQueryRepository.GetAll().ToListAsync();
            foreach (var company in compaies)
            {
                var db = new CompanyDbContext(company);
                db.Database.Migrate();
            }
        }
        public async Task UpdateCompany(Company company, CancellationToken cancellationToken)
        {
            _companyCommandRepository.Update(company);
            await _appUnitOfWork.SaveChangesAsync(cancellationToken);
        }
        public async Task UpdatePhotoCompany(string id, string companylogo, CancellationToken cancellationToken)
        {
            Company company = await _companyQueryRepository.GetById(id);
            if (company.CompanyLogo != null)
            {
                company.CompanyLogo = companylogo;
                company.CompanyLogo = "Test.png";
                _companyCommandRepository.Update(company);
                await _appUnitOfWork.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
