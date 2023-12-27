using FluentValidation;
namespace ATTicket.Application.Features.AppFeatures.CompanyFeatures.Commands.UpdateCompany;
public sealed class UpdateCompanyValidator : AbstractValidator<UpdateCompanyCommand>
{
    public UpdateCompanyValidator()
    {
        RuleFor(p => p.DatabaseName).NotEmpty().WithMessage("Database bilgisi yazılmalıdır!");
        RuleFor(p => p.DatabaseName).NotNull().WithMessage("Database bilgisi yazılmalıdır!");
        RuleFor(p => p.ServerName).NotEmpty().WithMessage("Server bilgisi yazılmalıdır!");
        RuleFor(p => p.ServerName).NotNull().WithMessage("Server bilgisi yazılmalıdır!");
        RuleFor(p => p.Name).NotEmpty().WithMessage("Şirket adı yazılmalıdır!");
        RuleFor(p => p.Name).NotNull().WithMessage("Şirket adı yazılmalıdır!");

        RuleFor(p => p.Address).NotEmpty().WithMessage("Adres Bilgileri Zorunludur!");
        RuleFor(p => p.Address).NotNull().WithMessage("Adres Bilgileri Zorunludur!");

        RuleFor(p => p.IdentityNumber).NotEmpty().WithMessage("Vergi Numarası Bilgileri Zorunludur!");
        RuleFor(p => p.IdentityNumber).NotNull().WithMessage("Vergi Numarası Bilgileri Zorunludur!");

        RuleFor(p => p.TaxDepartment).NotEmpty().WithMessage("Vergi Dairesi Bilgileri Zorunludur!");
        RuleFor(p => p.TaxDepartment).NotNull().WithMessage("Vergi Dairesi Bilgileri Zorunludur!");

        RuleFor(p => p.Tel).NotEmpty().WithMessage("Telefon Bilgileri Zorunludur!");
        RuleFor(p => p.Tel).NotNull().WithMessage("Telefon Bilgileri Zorunludur!");

        RuleFor(p => p.Email).NotEmpty().WithMessage("E-Mail Bilgileri Zorunludur!");
        RuleFor(p => p.Email).NotNull().WithMessage("E-Mail Bilgileri Zorunludur!");
    }
}