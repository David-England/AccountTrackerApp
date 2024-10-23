namespace AccountTrackerApp
{
	public interface IPersistence
	{
		public IEnumerable<Account> GetAccounts();

		public IEnumerable<Transaction> GetTransactions();

		public void SaveAccount(Account account);

		public void SaveTransaction(Transaction transaction);
	}
}
