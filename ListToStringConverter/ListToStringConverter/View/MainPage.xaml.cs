namespace ListToStringConverter;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void ListToStringClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListToStringPage());
    }
}

