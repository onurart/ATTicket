namespace ATTicket.Application.Features.CompanyFeatures.ViewClient.Commands.Create;
public sealed record CreateViewClientCommand
    (
    string Code,
    string Title,
    string FullName,
    string PhoneNumber,
    string EMail,
    string Representative,
    string RepresentativePhone,
    string RepresentativeEmail
    ) :ICommand<CreateViewClientCommandResponse>;

