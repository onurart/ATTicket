using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase;
public sealed record MigrateCompanyDatabasesCommand() : ICommand<MigrateCompanyDatabasesCommandResponse>;