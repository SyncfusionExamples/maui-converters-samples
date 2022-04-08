using DecimalValueConverter;

namespace DecimalValueConverter;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		
	}

	private async void DecimalValueButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new DecimalValueConverterView());
	}

	
}

