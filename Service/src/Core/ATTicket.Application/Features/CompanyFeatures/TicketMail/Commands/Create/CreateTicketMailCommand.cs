namespace ATTicket.Application.Features.CompanyFeatures.TicketMail.Commands.Create;
public  sealed record CreateTicketMailCommand
    (
      string TicketId,
      string MailSubject,
      string EMail,
      string EMailTo,
      string EMail_CC,
      string EMail_BCC,
      string EMail_Message):ICommand<CreateTicketMailCommandResponse>;