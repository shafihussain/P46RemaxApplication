using System.Windows;
using System.Data.OleDb;
using prjCSWinRemaxApplication.DataSource;

namespace prjCSWinRemaxApplication
{
    /// <summary>
    /// Interaction logic for Dasboard.xaml
    /// </summary>
    public partial class Dasboard : Window
    {
        public Dasboard()
        {
            InitializeComponent();
            Loaded += Dashboard_Loaded;
        }
        private void Dashboard_Loaded(object sender, RoutedEventArgs e) {
            //form load
            //New Connection to Database
            //DataSource.dataClass.myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= data\\RemaxApplicationDB.accdb");
            //DataSource.dataClass.myConn.Open();
        } 

        #region Button Exit
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Button Logout
            MainWindow logout = new MainWindow();
            logout.Show();
            this.Close();

        }
    }

}
