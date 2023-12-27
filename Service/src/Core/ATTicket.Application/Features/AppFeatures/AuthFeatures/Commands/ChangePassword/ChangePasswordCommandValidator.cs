namespace ATTicket.Application.Features.AppFeatures.AuthFeatures.Commands.ChangePassword;

public class ChangePasswordCommandValidator:AbstractValidator<ChangePasswordCommand>
{
    public ChangePasswordCommandValidator()
    {
        RuleFor(p => p.email).NotNull().WithMessage("Mail ya da kullanıcı adı yazmalısınız!");
        RuleFor(p => p.email).NotEmpty().WithMessage("Mail ya da kullanıcı adı yazmalısınız!");
        RuleFor(p => p.newPassword).NotNull().WithMessage("Şifre boş olamaz");
        RuleFor(p => p.newPassword).NotEmpty().WithMessage("Şifre boş olamaz");
        RuleFor(p => p.newPassword).MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır");
        RuleFor(p => p.newPassword).Matches("[A-Z]").WithMessage("Şifreniz en az 1 adet büyük harf içermelidir");
        RuleFor(p => p.newPassword).Matches("[a-z]").WithMessage("Şifreniz en az 1 adet küçük harf içermelidir");
        RuleFor(p => p.newPassword).Matches("[0-9]").WithMessage("Şifreniz en az 1 adet sayı içermelidir");
        RuleFor(p => p.newPassword).Matches("[^a-zA-Z0-9]").WithMessage("Şifreniz en az 1 adet özel karakter içermelidir");
    }
}