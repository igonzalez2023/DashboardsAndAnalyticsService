using Application.Wrappers;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.ReportBase.Commands.CreateReportBaseCommand;

public class CreateReportBaseCommand : IRequest<Response<Guid>>
{
    public string ReportKey { get; set; } = null!;
    public string ReportName { get; set; } = null!;
    public string JsonStructure { get; set; } = null!;
}

public class CreateReportBaseCommandHandler : IRequestHandler<CreateReportBaseCommand, Response<Guid>>
{
    private readonly IReportBaseRepository _repository;
    private readonly IMapper _mapper;

    public CreateReportBaseCommandHandler(IReportBaseRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public Task<Response<Guid>> Handle(CreateReportBaseCommand request, CancellationToken cancellationToken)
    {
        if (request is null)
            throw new ArgumentNullException(nameof(request), "Request must not be empty");
        return ProcessHandle(request, cancellationToken);
    }

    private async Task<Response<Guid>>  ProcessHandle(CreateReportBaseCommand request, CancellationToken cancellationToken)
    {
        var report = _mapper.Map<Domain.Entities.ReportBase>(request);
        var record = await _repository.AddAsync(report, cancellationToken);
        return new Response<Guid>(record.Id);
    }
}