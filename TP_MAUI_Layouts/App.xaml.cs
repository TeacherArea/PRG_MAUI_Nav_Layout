using Microsoft.Maui.Controls;

namespace TP_MAUI_Layouts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}