using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.AuthFeatures.Queries.GetAllUser;
public sealed record GetAllUserQuery() : IQuery<GetAllUserQueryResponse>;