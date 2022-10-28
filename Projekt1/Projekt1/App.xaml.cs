using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm;
using Projekt1.Managers;
using Projekt1.ViewModels;
using Projekt1.Views;
using Projekt1.Models;

namespace Projekt1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //
        private readonly NavigationManager _navigationManager;
        private readonly DataManager _dataManager;

        public App()
        {
            _navigationManager = new NavigationManager();
            _dataManager = new DataManager();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationManager.CurrentViewModel = new MainWindowModel(_navigationManager);
            var mainWindow = new MainWindow { DataContext = new MainWindowModel(_navigationManager) };
            mainWindow.Show();
            base.OnStartup(e);
        }
    }
}
