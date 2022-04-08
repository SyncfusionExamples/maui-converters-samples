using BoolToObjectConverter;

namespace BoolToObjectConverter;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
		
	}

	private async void BoolToObjectButton_clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new BoolToObjectConverterView());
	}

}

