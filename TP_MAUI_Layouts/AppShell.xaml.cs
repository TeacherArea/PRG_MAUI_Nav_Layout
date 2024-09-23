namespace TP_MAUI_Layouts
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("Stack", typeof(StackLayout));
            Routing.RegisterRoute("Flex", typeof(FlexLayout));
            Routing.RegisterRoute("Absolute", typeof(AbsoluteLayout));
        }
    }
}