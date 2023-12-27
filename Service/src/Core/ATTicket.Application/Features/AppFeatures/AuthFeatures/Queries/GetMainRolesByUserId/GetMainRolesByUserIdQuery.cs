using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.AuthFeatures.Queries.GetMainRolesByUserId;
public sealed record GetMainRolesByUserIdQuery(string UserId) : IQuery<GetMainRolesByUserIdQueryResponse>;