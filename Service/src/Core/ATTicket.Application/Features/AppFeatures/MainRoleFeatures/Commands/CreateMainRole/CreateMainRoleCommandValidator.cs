using ATTicket.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateRole;
using FluentValidation;
namespace ATTicket.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
public sealed class CreateMainRoleCommandValidator : AbstractValidator<CreateMainRoleCommand>
{
    public CreateMainRoleCommandValidator()
    {
        RuleFor(p => p.Title).NotEmpty().WithMessage("Role başlığı boş olmamaz!");
        RuleFor(p => p.Title).NotNull().WithMessage("Role başlığı boş olmamaz!");
    }
}