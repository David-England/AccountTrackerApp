namespace AccountTrackerApp
{
	public class Transaction
	{
		public Guid TransactionId { get; init; }
		public Account SourceAccount { get; init; }
		public Account TargetAccount { get; init; }
		public decimal Amount { get; init; }

		public static Dictionary<Guid, Transaction> Ledger
		{
			get
			{
				return Repository.Persistence.GetTransactions()
					.Select(t => new KeyValuePair<Guid, Transaction>(t.TransactionId, t))
					.ToDictionary();
			}
		}

		public Transaction(Guid transactionId, Account sourceAccount, Account targetAccount,
			decimal amount)
		{
			TransactionId = transactionId;
			SourceAccount = sourceAccount;
			TargetAccount = targetAccount;
			Amount = decimal.Round(amount, 2);
		}

		public static void Create(Account sourceAccount, Account targetAccount, decimal amount)
		{
			var transactions = new List<Transaction>()
			{
				new Transaction(Guid.NewGuid(), sourceAccount, targetAccount, amount),
				new Transaction(Guid.NewGuid(), targetAccount, sourceAccount, -amount)
			};

			foreach (Transaction tx in transactions)
			{
				tx.TargetAccount.CurrentValue += tx.Amount;

				Repository.Persistence.AddTransaction(tx);
				Repository.Persistence.UpdateAccount(tx.TargetAccount);
			}
		}
	}
}
