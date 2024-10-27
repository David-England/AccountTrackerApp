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

		internal static Account Create(string accountName, string accountHolderName)
		{
			return new(Guid.NewGuid(), accountName, accountHolderName);
		}

		internal static Account CreateDummy() => Create(string.Empty, string.Empty);

		internal void SaveNew(IPersistence persistence) => persistence.AddAccount(this);
	}
}
