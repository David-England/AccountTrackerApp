namespace AccountTrackerApp
{
	public class Account
	{
		public Guid AccountId { get; init; }
		public string AccountName { get; set; }
		public string AccountHolderName { get; set; }
		public decimal CurrentValue { get; internal set; }

		public Account(string accountName, string accountHolderName)
		{
			AccountId = Guid.NewGuid();
			AccountName = accountName;
			AccountHolderName = accountHolderName;
		}

		public static Account CreateDummy() => new Account(string.Empty, string.Empty);
	}
}
