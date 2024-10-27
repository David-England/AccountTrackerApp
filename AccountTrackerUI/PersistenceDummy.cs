using AccountTrackerApp;

namespace AccountTrackerUI
{
	internal class PersistenceDummy : IPersistence
	{
		private List<Account> _accounts = new();
		private List<Transaction> _transactions = new();

		public IEnumerable<Account> GetAccounts() { return _accounts; }

		public IEnumerable<Transaction> GetTransactions() {  return _transactions; }

		public void AddAccount(Account account) => _accounts.Add(account);

		public void AddTransaction(Transaction transaction) => _transactions.Add(transaction);

		public void UpdateAccount(Account account)
		{
			var originalAccount = _accounts.First(a => a.AccountId == account.AccountId);

			originalAccount.AccountName = account.AccountName;
			originalAccount.AccountHolderName = account.AccountHolderName;
		}
	}
}
