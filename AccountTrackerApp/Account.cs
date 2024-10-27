namespace AccountTrackerApp
{
	public class Account
	{
		public Guid AccountId { get; init; }
		public string AccountName { get; set; }
		public string AccountHolderName { get; set; }
		public decimal CurrentValue { get; internal set; }

		public Account(Guid accountId, string accountName, string accountHolderName,
			decimal currentValue = 0.00m)
		{
			AccountId = accountId;
			AccountName = accountName;
			AccountHolderName = accountHolderName;
			CurrentValue = currentValue;
		}

		public static Account Create(string accountName, string accountHolderName)
		{
			var account = new Account(Guid.NewGuid(), accountName, accountHolderName);
			Repository.Persistence.AddAccount(account);
			return account;
		}

		public static Account CreateDummy() => Create(string.Empty, string.Empty);
	}
}
