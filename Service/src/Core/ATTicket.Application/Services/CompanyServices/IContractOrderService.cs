namespace ATTicket.Application.Services.CompanyServices
{
    public  interface IContractOrderService
    {
        Task<IList<ContractOrder>> GetAllAsync(string companyId);
        Task<ContractOrder> GetByIdAsync(string id, string companyId);
        Task<ContractOrder> CreateContractOrderAsync(CreateBasketStatusCommand request, CancellationToken cancellationToken);
        Task<ContractOrder> RemoveByIdContractOrderAsync(string id, string companyId);
        Task UpdateAsync(ContractOrder contractOrder, string companyId);
    }
}
