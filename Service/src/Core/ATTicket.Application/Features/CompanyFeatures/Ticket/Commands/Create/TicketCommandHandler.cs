using ATTicket.Application.Services;
using ATTicket.Application.Services.CompanyServices;
using Newtonsoft.Json;

namespace ATTicket.Application.Features.CompanyFeatures.Ticket.Commands.Create
{
    public sealed class TicketCommandHandler : ICommandHandler<CreateTicketCommand, CreateTicketCommandResponse>
    {
        private readonly ITicketServixe _service;
        private readonly ILogService _logService;
        private readonly IApiService _apiService;
        public TicketCommandHandler(ITicketServixe service, ILogService logService, IApiService apiService)
        {
            _service = service;
            _logService = logService;
            _apiService = apiService;
        }
        public async Task<CreateTicketCommandResponse> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
        {
            Tickets tickets = await _service.CreateTicketAsync(request, cancellationToken);
            string userId = _apiService.GetUserIdByToken();
            Log log = new()
            {
                Id = Guid.NewGuid().ToString(),
                TableName = nameof(Tickets),
                Progress = "Create",
                UserId = userId,
                Data = JsonConvert.SerializeObject(tickets)
            };
            await _logService.AddAsync(log, request.companyId);
            return new();
        }
    }
}
