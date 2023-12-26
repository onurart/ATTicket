namespace ATTicket.Domain;
public interface IContextService
{
    DbContext CreateDbContextInstance(string companyId);
}