using System.Windows;

namespace Tema_1
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            bool isStandardOn = Tema_1.Properties.Settings.Default.IsStandardOn;
            bool isDigitGroupingOn = Tema_1.Properties.Settings.Default.IsDigitGroupingOn;

            if (isStandardOn)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                Programmer programmerWindow = new Programmer();
                programmerWindow.Show();
            }
        }
    }
}