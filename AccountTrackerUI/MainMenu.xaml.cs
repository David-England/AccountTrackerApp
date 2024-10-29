using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AccountTrackerApp;

namespace AccountTrackerUI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainMenu : Window
	{
		private IAccountTracker _accountTracker;

		public MainMenu()
		{
			InitializeComponent();

			_accountTracker = new AccountTracker(new PersistenceDummy());
			_accountTracker.CreateAccount("My General Account", "MR X. HUMAN");
		}

		private void btnAdd10_Click(object sender, RoutedEventArgs e)
		{
			Account account = _accountTracker.GetAccounts().First();

			_accountTracker.TransferInExternal(account, 10.00m);
			lblAmount.Content = $"£{account.CurrentValue}";
		}
	}
}