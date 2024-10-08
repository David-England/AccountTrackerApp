namespace AccountTrackerApp
{
	internal class Transaction
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
			Amount = amount;
		}

		public static void CreateTransaction(Account sourceAccount, Account targetAccount,
			decimal amount)
		{
			var forwardsTransaction = new Transaction(sourceAccount, targetAccount, amount);
			var backwardsTransaction = new Transaction(targetAccount, sourceAccount, -amount);

			Ledger.Add(forwardsTransaction.TransactionId, forwardsTransaction);
			Ledger.Add(backwardsTransaction.TransactionId, backwardsTransaction);

			sourceAccount.CurrentValue += forwardsTransaction.Amount;
			targetAccount.CurrentValue += backwardsTransaction.Amount;
		}
	}
}
