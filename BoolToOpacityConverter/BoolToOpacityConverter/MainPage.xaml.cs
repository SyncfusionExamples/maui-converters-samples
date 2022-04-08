namespace BoolToOpacityConverter;
using BoolToOpacityConverter.Samples;
using System.Windows.Input;

public partial class MainPage : ContentPage
{
	

   

	public MainPage()
	{
		InitializeComponent();	
	}
	
    private async void BoolToOpacityTapped(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new BoolToOpacityConverterSamplePage());
	}

}

