using Microsoft.EntityFrameworkCore;

namespace WebAPI.Infrastructure
{
    public class DocumentDbContext : DbContext, IDocumentDbContext
    {
        public DbSet<Document> Documents { get; set; }
        public DocumentDbContext(DbContextOptions<DocumentDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookShopConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
