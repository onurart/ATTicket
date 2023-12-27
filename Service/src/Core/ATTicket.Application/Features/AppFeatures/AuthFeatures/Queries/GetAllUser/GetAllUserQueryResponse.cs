using ATTicket.Domain.Dtos;
namespace ATTicket.Application.Features.AppFeatures.AuthFeatures.Queries.GetAllUser;
public sealed record GetAllUserQueryResponse(List<UsersDto> Users);