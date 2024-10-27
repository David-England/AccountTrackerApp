namespace AccountTrackerApp
{
	public interface IPersistence
	{
		IEnumerable<Account> GetAccounts();

		IEnumerable<Transaction> GetTransactions();

		void AddAccount(Account account);

		void AddTransaction(Transaction transaction);

		void UpdateAccount(Account account);
	}
}
