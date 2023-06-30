using Ardalis.Specification.EntityFrameworkCore;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class ReportBaseRepository : RepositoryBase<ReportBase>, IReportBaseRepository
{
    public ReportBaseRepository(DbContext dbContext) : base(dbContext)
    {
    }
}