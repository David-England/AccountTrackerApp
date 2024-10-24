using AccountTrackerApp;
using AccountTrackerDB;

namespace AccountTrackerWeb.Services
{
	public class AccountContainer : IAccountContainer
	{
		public List<Account> Accounts
		{
			get => Repository.Persistence.GetAccounts()
				// Hack to exclude dummy accounts
				.Where(a => !string.IsNullOrEmpty(a.AccountName)
					|| !string.IsNullOrEmpty(a.AccountHolderName))
				.ToList();
		}

		public AccountContainer()
		{
			Repository.Persistence = new RepositoryContext();
		}
	}
}
