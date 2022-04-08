namespace IsListNotNullOrEmptyConverter;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private async void IsListNotNullOrEmptyConverterButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new IsListNotNullOrEmptyConverterPage());
    }

}

