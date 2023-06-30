using Ardalis.Specification.EntityFrameworkCore;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class ReportDataRepository : RepositoryBase<ReportData>, IReportDataRepository
{
    public ReportDataRepository(DbContext dbContext) : base(dbContext)
    {
    }
}