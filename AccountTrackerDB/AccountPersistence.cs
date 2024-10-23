using AccountTrackerApp;

namespace AccountTrackerDB
{
	internal class AccountPersistence
	{
		public int Id { get; set; }
		public string? AccountId { get; set; }
		public string? AccountName { get; set; }
		public string? AccountHolderName { get; set; }
		public decimal CurrentValue { get; set; }

		public Account ToAccount() => new Account(AccountName!, AccountHolderName!);

		public static AccountPersistence Create(Account account)
		{
			return new AccountPersistence()
			{
				AccountId = account.AccountId.ToString(),
				AccountName = account.AccountName,
				AccountHolderName = account.AccountHolderName
			};
		}
	}
}
