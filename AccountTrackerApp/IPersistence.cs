namespace AccountTrackerApp
{
	public interface IPersistence
	{
		public IEnumerable<Account> GetAccounts();

		public IEnumerable<Transaction> GetTransactions();

		public void AddAccount(Account account);

		public void AddTransaction(Transaction transaction);

		public void UpdateAccount(Account account);
	}
}
