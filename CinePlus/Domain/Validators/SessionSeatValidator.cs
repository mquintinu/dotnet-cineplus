using CinePlus.Domain.Models;
using FluentValidation;

namespace CinePlus.Domain.Validators;

public class SessionSeatValidator : AbstractValidator<SessionSeat>
{
    public SessionSeatValidator()
    {
        RuleFor(sessionSeat => sessionSeat.Document)
            .NotEmpty()
            .WithMessage("O documento não pode ser nulo!");

        RuleFor(sessionSeat => sessionSeat.SessionId)
            .GreaterThan(0)
            .WithMessage("O Id da seção deve ser maior que zero!");
    }
}
