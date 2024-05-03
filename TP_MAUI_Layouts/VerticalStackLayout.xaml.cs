namespace TP_MAUI_Layouts;
using Microsoft.Maui.Graphics;


public partial class VerticalStackLayout : ContentPage
{
	public VerticalStackLayout()
	{
		InitializeComponent();
        AutoGenerateLabel();
	}

	private void ButtonGoBack_Click(object sender, EventArgs e)
	{
		Navigation.PushAsync(new StackLayout());
	}

	private void AutoGenerateLabel()
	{
        for (int i = 1; i <= 50; i++)
        {
            Label label = new Label
            {
                Text = "Some content, no " + i,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                BackgroundColor = Color.FromArgb("#808080"),
                Margin = 5,
                TextColor = Color.FromArgb("#FFFFFF"),
                Padding = new Thickness(10)
            };

            this.verticalStackLayout.Children.Add(label);
        }
    }
}