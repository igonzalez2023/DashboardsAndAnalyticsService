namespace Application.DTOs;

public class ReportBaseDto
{
    public Guid Id { get; set; }
    public bool Status { get; set; }
    public string ReportKey { get; set; } = null!;
    public string ReportName { get; set; } = null!;
    public string JsonStructure { get; set; } = null!;
}