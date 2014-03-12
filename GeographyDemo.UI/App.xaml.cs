using GeographyDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Autofac.Features;
using Autofac;


namespace GeographyDemo.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            var container = GeographyUIConfigurator.CreateAndConfigureDependencyContainer();
            this.MainWindow = new MainWindow { DataContext = container.Resolve<MainWindowViewModel>() };
            this.MainWindow.Show();

        }
    }
}
