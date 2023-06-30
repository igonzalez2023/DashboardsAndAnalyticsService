using Application.Wrappers;
using Domain.Repositories;
using MediatR;

namespace Application.Features.ReportBase.Commands.DeleteReportBaseCommand;

public class DeleteReportBaseCommand : IRequest<Response<bool>>
{
    public Guid Id { get; set; }
}

public class DeleteReportBaseCommandHandler : IRequestHandler<DeleteReportBaseCommand, Response<bool>>
{
    private readonly IReportBaseRepository _repository;

    public DeleteReportBaseCommandHandler(IReportBaseRepository repository)
    {
        _repository = repository;
    }

    public Task<Response<bool>> Handle(DeleteReportBaseCommand request, CancellationToken cancellationToken)
    {
        if (request is null)
            throw new ArgumentNullException(nameof(request), "Request must not be empty");
        return ProcessHandle(request, cancellationToken);
    }

    private async Task<Response<bool>> ProcessHandle(DeleteReportBaseCommand request,
        CancellationToken cancellationToken)
    {
        var report = await _repository.GetByIdAsync(request.Id, cancellationToken);
        if (report is null)
            return new Response<bool>(false);
        report.State = false;
        await _repository.UpdateAsync(report, cancellationToken);
        return new Response<bool>(true);
    }
}