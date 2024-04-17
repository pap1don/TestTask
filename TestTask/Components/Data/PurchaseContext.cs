using Microsoft.EntityFrameworkCore;

namespace TestTask.Components.data
{
    public class PurchaseContext : DbContext
    {
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<ProposalMaterial> ProposalMaterials { get; set; }
        public PurchaseContext(DbContextOptions<PurchaseContext> options) : base(options)
        { }

    }
}
