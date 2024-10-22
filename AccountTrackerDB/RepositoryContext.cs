using Microsoft.EntityFrameworkCore;

namespace AccountTrackerDB
{
	public class RepositoryContext : DbContext
	{
		DbSet<AccountPersistence> AccountPersistences { get; set; }
		DbSet<TransactionPersistence> TransactionPersistences { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(
				"Server=Davidstower;Database=AccountTrackerApp01;Trusted_Connection=True;TrustServerCertificate=True;");
		}
	}
}
