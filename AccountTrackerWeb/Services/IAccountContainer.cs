using AccountTrackerApp;

namespace AccountTrackerWeb.Services
{
	public interface IAccountContainer
	{
		List<Account> Accounts { get; set; }
	}
}
