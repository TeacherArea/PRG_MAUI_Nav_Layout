namespace TP_MAUI_Layouts
{
    public partial class StackLayout : ContentPage
    {
        int count = 0;

        public StackLayout()
        {
            InitializeComponent();
        }

        private void OnCounter_Clicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void ButtonVerticalStackLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VerticalStackLayout());
        }
    }
}