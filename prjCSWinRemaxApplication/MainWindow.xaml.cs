using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prjCSWinRemaxApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance;

        public MainWindow()
        {
            Instance = this;
            //this.DataContext = new MainWindowViewModel();
            InitializeComponent();
        }

        #region Button Exit
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        #endregion

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //if login is successful, close the current window and present user with dashboard View
            Dasboard dashboard = new Dasboard();
            App.Current.MainWindow = dashboard;
            this.Close();
            dashboard.Show();
        }

        public void Display(string className)
        {
            Type type = Type.GetType("prjCSWinRemaxApplication.View" + className);
            if (type == null) return;

            UserControl pageView = (UserControl)Activator.CreateInstance(type);

            //GridPrincipal.Children.Clear();
            //GridPrincipal.Children.Add(pageView);

        }
    }
}
