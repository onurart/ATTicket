namespace ATTicket.Application.Features.CompanyFeatures.ContractDocument.Commands.Create
{
    public sealed record class CreateContractDocumentCommand
                               (string? FileName,
                                string? DocumentData,
                                string? ContentType):ICommand<CreateContractDocumentCommandResponse>;
                                


}
