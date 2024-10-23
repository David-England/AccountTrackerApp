using AccountTrackerApp;
using Microsoft.EntityFrameworkCore;

namespace AccountTrackerDB
{
	public class RepositoryContext : DbContext, IPersistence
	{
		DbSet<AccountPersistence> AccountPersistences { get; set; }
		DbSet<TransactionPersistence> TransactionPersistences { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(
				"Server=Davidstower;Database=AccountTrackerApp01;Trusted_Connection=True;TrustServerCertificate=True;");
		}

		public IEnumerable<Account> GetAccounts()
		{
			return AccountPersistences.Select(ap => ap.ToAccount());
		}

		public IEnumerable<Transaction> GetTransactions()
		{
			return TransactionPersistences.Select(tp => tp.ToTransaction());
		}

		public void SaveAccount(Account account)
		{
			AccountPersistences.Add(AccountPersistence.Create(account));
			SaveChanges();
		}

		public void SaveTransaction(Transaction transaction)
		{
			TransactionPersistences.Add(TransactionPersistence.Create(transaction));
			SaveChanges();
		}
	}
}
