namespace AccountTrackerApp
{
	public class AccountTracker : IAccountTracker
	{
		private IPersistence _persistence;

		public AccountTracker(IPersistence persistence)
		{
			_persistence = persistence;
		}

		public IEnumerable<Account> GetAccounts()
		{
			return _persistence.GetAccounts()
				.Where(a => a.AccountName != string.Empty || a.AccountHolderName != string.Empty)
				.ToList();
		}

		public IEnumerable<Transaction> GetTransactions()
		{
			return _persistence.GetTransactions().ToList();
		}

		public void CreateAccount(string accountName, string accountHolderName)
		{
			Account.Create(accountName, accountHolderName).SaveNew(_persistence);
		}

		public Account CreateDummyAccount()
		{
			Account dummy = Account.CreateDummy();
			_persistence.AddAccount(dummy);
			return dummy;
		}

		public void CreateTransaction(Account sourceAccount, Account targetAccount, decimal amount)
		{
			Transaction[] bothTransactions = Transaction.Create(sourceAccount, targetAccount,
				amount);

			foreach (Transaction transaction in bothTransactions)
				transaction.SaveNew(_persistence);
		}
	}
}
