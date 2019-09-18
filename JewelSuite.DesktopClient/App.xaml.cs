using JewelSuite.DesktopClient.Helper;
using System;
using System.Windows;

namespace JewelSuite.DesktopClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            GlobalExceptionHandler();
        }


        private void GlobalExceptionHandler()
        {
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                    ExceptionHandler.GlobalUnhandledExceptionHandler((Exception)e.ExceptionObject, "AppDomain.CurrentDomain.UnhandledException");
        }
    }
}
