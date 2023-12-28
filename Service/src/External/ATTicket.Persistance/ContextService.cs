using ATTicket.Domain;
using ATTicket.Domain.AppEntities;
using ATTicket.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace ATTicket.Persistance
{
    internal class ContextService : IContextService
    {
        private readonly AppDbContext _appContext;
        public ContextService(AppDbContext appContext)
        {
            _appContext = appContext;
        }
        public DbContext CreateDbContextInstance(string companyId)
        {
            Company company = _appContext.Set<Company>().Find(companyId);
            return new CompanyDbContext(company);
        }
    }
}
