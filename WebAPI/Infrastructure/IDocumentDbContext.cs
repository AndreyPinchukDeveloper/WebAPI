using Microsoft.EntityFrameworkCore;

namespace WebAPI.Infrastructure
{
    public interface IDocumentDbContext
    {
        DbSet<Document> Documents { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
