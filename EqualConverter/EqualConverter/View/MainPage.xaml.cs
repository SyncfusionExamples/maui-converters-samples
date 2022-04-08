namespace EqualConverter;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}


    private void EqualConverterClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EqualConverterPage());
    }

}

