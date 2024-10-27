namespace AccountTrackerApp
{
	public class Transaction
	{
		public Guid TransactionId { get; init; }
		public Account SourceAccount { get; init; }
		public Account TargetAccount { get; init; }
		public decimal Amount { get; init; }

		public Transaction(Guid transactionId, Account sourceAccount, Account targetAccount,
			decimal amount)
		{
			TransactionId = transactionId;
			SourceAccount = sourceAccount;
			TargetAccount = targetAccount;
			Amount = decimal.Round(amount, 2);
		}

		internal static Transaction[] Create(Account sourceAccount, Account targetAccount,
			decimal amount)
		{
			var transactions = new List<Transaction>()
			{
				new Transaction(Guid.NewGuid(), sourceAccount, targetAccount, amount),
				new Transaction(Guid.NewGuid(), targetAccount, sourceAccount, -amount)
			};

			foreach (Transaction tx in transactions)
				tx.TargetAccount.CurrentValue += tx.Amount;

			return transactions.ToArray();
		}

		internal void SaveNew(IPersistence persistence)
		{
			persistence.AddTransaction(this);
			persistence.UpdateAccount(TargetAccount);
		}
	}
}
