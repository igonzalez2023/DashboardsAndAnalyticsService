using Atos.Core.Commons;

namespace Domain.Entities;

public class ReportData : EntityBaseAuditable<Guid, Guid>
{
    public string ReportKey { get; set; } = null!;
    public string Data { get; set; } = null!;
}