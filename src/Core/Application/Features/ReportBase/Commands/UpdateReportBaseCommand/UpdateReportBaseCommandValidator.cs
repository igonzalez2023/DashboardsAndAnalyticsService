using FluentValidation;

namespace Application.Features.ReportBase.Commands.UpdateReportBaseCommand;

public class UpdateReportBaseCommandValidator : AbstractValidator<UpdateReportBaseCommand>
{
    public UpdateReportBaseCommandValidator()
    {
        RuleFor(r => r.Id)
            .NotEmpty().WithMessage("{PropertyName} must not be empty");
        
        RuleFor(r => r.ReportKey)
            .NotEmpty().WithMessage("{PropertyName} must not be empty")
            .MaximumLength(9).WithMessage("{PropertyName} must not exceed {MaxLength} characters");
            
        RuleFor(r => r.ReportName)
            .NotEmpty().WithMessage("{PropertyName} must not be empty")
            .MaximumLength(30).WithMessage("{PropertyName} must not exceed {MaxLength} characters");
            
        RuleFor(r => r.JsonStructure)
            .NotEmpty().WithMessage("{PropertyName} must not be empty");
    }
}