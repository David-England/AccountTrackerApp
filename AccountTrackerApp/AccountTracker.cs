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

		public void CreateAccount(string accountName, string accountHolderName)
		{
			Account.Create(accountName, accountHolderName).SaveNew(Persistence);
		}

		public Account CreateDummyAccount()
		{
			Account dummy = Account.CreateDummy();
			Persistence.AddAccount(dummy);
			return dummy;
		}

		public void CreateTransaction(Account sourceAccount, Account targetAccount, decimal amount)
		{
			Transaction[] bothTransactions = Transaction.Create(sourceAccount, targetAccount,
				amount);

			foreach (Transaction transaction in bothTransactions)
				transaction.SaveNew(Persistence);
		}
	}
}
