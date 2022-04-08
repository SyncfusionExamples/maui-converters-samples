namespace IsStringNotNullOrWhiteSpaceConverter;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	
	private async void IsStringNotNullOrWhiteSpaceConverterButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new IsStringNotNullOrWhiteSpaceConverterPage());
	}

}

