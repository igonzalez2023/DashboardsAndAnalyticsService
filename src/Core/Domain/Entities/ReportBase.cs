using Atos.Core.Commons;

namespace Domain.Entities;

public class ReportBase : EntityBaseAuditable<Guid, Guid>
{
    public string ReportKey { get; set; } = null!;
    public string ReportName { get; set; } = null!;
    public string JsonStructure { get; set; } = null!;
}