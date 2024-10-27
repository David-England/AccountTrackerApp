namespace AccountTrackerApp
{
	public interface IAccountTracker
	{
		IEnumerable<Account> GetAccounts();

		IEnumerable<Transaction> GetTransactions();

		void CreateAccount(string accountName, string accountHolderName);

		Account CreateDummyAccount();

		void CreateTransaction(Account sourceAccount, Account targetAccount, decimal amount);
	}
}
