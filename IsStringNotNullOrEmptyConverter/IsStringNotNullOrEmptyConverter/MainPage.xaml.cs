namespace IsStringNotNullOrEmptyConverter;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private async void IsStringNotNullOrEmptyConverterButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new IsStringNotNullOrEmptyConverterPage());
    }

}

