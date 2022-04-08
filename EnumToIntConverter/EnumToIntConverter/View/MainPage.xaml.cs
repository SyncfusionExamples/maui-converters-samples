namespace EnumToIntConverter;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void EnumToIntClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EnumToIntPage());
    }

}

