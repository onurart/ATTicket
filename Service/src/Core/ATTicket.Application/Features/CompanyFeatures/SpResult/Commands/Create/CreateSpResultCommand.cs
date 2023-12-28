namespace ATTicket.Application.Features.CompanyFeatures.SpResult.Commands.Create;

public sealed record CreateSpResultCommand(string? Result):ICommand<CreateSpResultCommandResponse>;

