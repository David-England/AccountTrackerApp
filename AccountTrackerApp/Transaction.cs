namespace AccountTrackerApp
{
	public class Transaction
	{
		public Guid TransactionId { get; init; }
		public Account SourceAccount { get; init; }
		public Account TargetAccount { get; init; }
		public decimal Amount { get; init; }

		public static Dictionary<Guid, Transaction> Ledger { get; private set; }
			= new Dictionary<Guid, Transaction>();

		private Transaction(Account sourceAccount, Account targetAccount, decimal amount)
		{
			TransactionId = Guid.NewGuid();
			SourceAccount = sourceAccount;
			TargetAccount = targetAccount;
			Amount = decimal.Round(amount, 2);
		}

		public static void Create(Account sourceAccount, Account targetAccount, decimal amount)
		{
			var forwardsTransaction = new Transaction(sourceAccount, targetAccount, amount);
			var backwardsTransaction = new Transaction(targetAccount, sourceAccount, -amount);

			Ledger.Add(forwardsTransaction.TransactionId, forwardsTransaction);
			Ledger.Add(backwardsTransaction.TransactionId, backwardsTransaction);

			targetAccount.CurrentValue += forwardsTransaction.Amount;
			sourceAccount.CurrentValue += backwardsTransaction.Amount;
		}
	}
}
