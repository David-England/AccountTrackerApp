namespace AccountTrackerApp
{
	public interface IAccountTracker
	{
		IEnumerable<Account> GetAccounts();

		IEnumerable<Transaction> GetTransactions();

		void CreateAccount(string accountName, string accountHolderName);

		void Transfer(Account sourceAccount, Account targetAccount, decimal amount);

		void TransferInExternal(Account targetAccount, decimal amount);

		void TransferOutExternal(Account sourceAccount, decimal amount);
	}
}
