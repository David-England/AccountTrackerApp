using AccountTrackerApp;
using Microsoft.EntityFrameworkCore;

namespace AccountTrackerDB
{
	public class RepositoryContext : DbContext, IPersistence
	{
		DbSet<AccountPersistence> AccountPersistences { get; set; }
		DbSet<TransactionPersistence> TransactionPersistences { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			ModelBuildUtility.SetupAccountPersistence(modelBuilder);
			ModelBuildUtility.SetupTransactionPersistence(modelBuilder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(
				"Server=Davidstower;Database=AccountTrackerApp01;Trusted_Connection=True;TrustServerCertificate=True;");
		}

		public IEnumerable<Account> GetAccounts()
		{
			return AccountPersistences
				.Select(ap => ap.ToAccount())
				.ToList();
		}

		public IEnumerable<Transaction> GetTransactions()
		{
			return TransactionPersistences
				.Select(tp => tp.ToTransaction())
				.ToList();
		}

		public void AddAccount(Account account)
		{
			AccountPersistences.Add(AccountPersistence.Create(account));
			SaveChanges();
		}

		public void AddTransaction(Transaction transaction)
		{
			var sourceAP = AccountPersistences
				.First(ap => ap.AccountId == transaction.SourceAccount.AccountId.ToString());
			var targetAP = AccountPersistences
				.First(ap => ap.AccountId == transaction.TargetAccount.AccountId.ToString());

			TransactionPersistences.Add(TransactionPersistence.Create(transaction, sourceAP,
				targetAP));
			SaveChanges();
		}

		public void UpdateAccount(Account account)
		{
			AccountPersistences
				.First(ap => ap.AccountId == account.AccountId.ToString())
				.Update(account);

			SaveChanges();
		}
	}
}
