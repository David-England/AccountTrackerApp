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

		public Account ToAccount()
		{
			return new Account(Guid.Parse(AccountId!), AccountName!, AccountHolderName!,
				CurrentValue);
		}

		public void Update(Account account)
		{
			AccountId = account.AccountId.ToString();
			AccountName = account.AccountName;
			AccountHolderName = account.AccountHolderName;
			CurrentValue = account.CurrentValue;
		}

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
