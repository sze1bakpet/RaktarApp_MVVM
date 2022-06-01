using RaktarApp_MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RaktarApp_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application 
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            KeszletViewModel keszletViewModel = new KeszletViewModel();

            MainWindow mainWindow = new MainWindow();

            mainWindow.DataContext = keszletViewModel;

            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}