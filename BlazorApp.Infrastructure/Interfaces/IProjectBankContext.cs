using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Infrastructure{

    public interface IProjectBankContext : IDisposable
    {
        DbSet<Project> Projects { get; }
        DbSet<Student> Students { get; }
        
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
