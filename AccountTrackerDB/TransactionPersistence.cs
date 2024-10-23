using AccountTrackerApp;

namespace AccountTrackerDB
{
	internal class TransactionPersistence
	{
		public int Id { get; set; }
		public string? TransactionId { get; set; }
		public AccountPersistence? SourceAccount { get; set; }
		public AccountPersistence? TargetAccount { get; set; }
		public decimal Amount { get; set; }

		public Transaction ToTransaction()
		{
			return
				new Transaction(SourceAccount?.ToAccount()!, TargetAccount?.ToAccount()!, Amount);
		}

		public static TransactionPersistence Create(Transaction transaction)
		{
			var sourceAP = AccountPersistence.Create(transaction.SourceAccount);
			var targetAP = AccountPersistence.Create(transaction.TargetAccount);

			return new TransactionPersistence()
			{
				TransactionId = transaction.TransactionId.ToString(),
				SourceAccount = sourceAP,
				TargetAccount = targetAP,
				Amount = transaction.Amount
			};
		}
	}
}
