namespace TP_MAUI_Layouts;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}

	private async void GoToStack(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("Stack");
	}

    private async void GoToFlex(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Flex");
    }

    private async void GoToAbsolute(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Absolute");
    }
}