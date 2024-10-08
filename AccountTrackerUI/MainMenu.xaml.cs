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
		public MainMenu()
		{
			InitializeComponent();

			var myAccount = new Account("My General Account", "MR X. HUMAN");
		}
	}
}