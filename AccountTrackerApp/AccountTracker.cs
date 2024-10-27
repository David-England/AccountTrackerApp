namespace AccountTrackerApp
{
	public class AccountTracker : IAccountTracker
	{
		internal IPersistence Persistence { get; }

		public AccountTracker(IPersistence persistence)
		{
			Persistence = persistence;
		}

		public IEnumerable<Account> GetAccounts()
		{
			return Persistence.GetAccounts()
				.Where(a => a.AccountName != string.Empty || a.AccountHolderName != string.Empty)
				.ToList();
		}

		public IEnumerable<Transaction> GetTransactions()
		{
			return Persistence.GetTransactions().ToList();
		}

		public Account CreateAccount(string accountName, string accountHolderName)
		{
			return Account.Create(Persistence, accountName, accountHolderName);
		}

		public Account CreateDummyAccount() => Account.CreateDummy(Persistence);

		public void CreateTransaction(Account sourceAccount, Account targetAccount, decimal amount)
		{
			Transaction.Create(Persistence, sourceAccount, targetAccount, amount);
		}
	}
}
