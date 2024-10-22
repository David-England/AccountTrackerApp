using Microsoft.EntityFrameworkCore;

namespace AccountTrackerDB
{
	public class RepositoryContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}
	}
}
