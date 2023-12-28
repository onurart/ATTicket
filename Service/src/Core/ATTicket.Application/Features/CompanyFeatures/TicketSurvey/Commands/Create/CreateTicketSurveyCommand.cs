namespace ATTicket.Application.Features.CompanyFeatures.TicketSurvey.Commands.Create;
public sealed record CreateTicketSurveyCommand
                     (
                       int SurveyPoint,
                       string TicketId,
                       string SurveyNote
                    ) :ICommand<CreateTicketSurveyCommandResponse>;   

