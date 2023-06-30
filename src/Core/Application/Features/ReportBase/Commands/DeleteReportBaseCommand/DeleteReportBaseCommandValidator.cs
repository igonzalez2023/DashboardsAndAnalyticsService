using FluentValidation;

namespace Application.Features.ReportBase.Commands.DeleteReportBaseCommand;

public class DeleteReportBaseCommandValidator : AbstractValidator<DeleteReportBaseCommand>
{
    public DeleteReportBaseCommandValidator()
    {
        RuleFor(r => r.Id)
            .NotEmpty().WithMessage("{PropertyName} must not be empty");
    }   
}