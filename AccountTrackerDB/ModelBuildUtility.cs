using Microsoft.EntityFrameworkCore;

namespace AccountTrackerDB
{
	internal static class ModelBuildUtility
	{
		public static void SetupAccountPersistence(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AccountPersistence>()
				.Property(ap => ap.Id)
				.HasColumnName("id");

			modelBuilder.Entity<AccountPersistence>()
				.Property(ap => ap.AccountId)
				.IsRequired()
				.HasColumnName("account_id");

			modelBuilder.Entity<AccountPersistence>()
				.Property(ap => ap.AccountName)
				.IsRequired()
				.HasColumnName("account_name");

			modelBuilder.Entity<AccountPersistence>()
				.Property(ap => ap.AccountHolderName)
				.IsRequired()
				.HasColumnName("account_holder_name");

			modelBuilder.Entity<AccountPersistence>()
				.Property(ap => ap.CurrentValue)
				.HasPrecision(18, 2)
				.HasColumnName("current_value");
		}

		public static void SetupTransactionPersistence(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<TransactionPersistence>()
				.Property(tp => tp.Id)
				.HasColumnName("id");

			modelBuilder.Entity<TransactionPersistence>()
				.Property(tp => tp.TransactionId)
				.IsRequired()
				.HasColumnName("transaction_id");

			modelBuilder.Entity<TransactionPersistence>()
				.HasOne(tp => tp.SourceAccount)
				.WithMany()
				.IsRequired()
				.OnDelete(DeleteBehavior.NoAction)
				.HasForeignKey("source_account_id");

			modelBuilder.Entity<TransactionPersistence>()
				.HasOne(tp => tp.TargetAccount)
				.WithMany()
				.IsRequired()
				.OnDelete(DeleteBehavior.NoAction)
				.HasForeignKey("target_account_id");

			modelBuilder.Entity<TransactionPersistence>()
				.Property(tp => tp.Amount)
				.HasPrecision(18, 2)
				.HasColumnName("amount");
		}
	}
}
