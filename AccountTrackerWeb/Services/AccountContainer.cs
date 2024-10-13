using AccountTrackerApp;

namespace AccountTrackerWeb.Services
{
	public class AccountContainer : IAccountContainer
	{
		public List<Account> Accounts { get; set; }

		public AccountContainer()
		{
			Accounts = new List<Account>();
		}
	}
}
