namespace DoubleToIntConverter;
using DoubleToIntConverter.Samples;
using System.Windows.Input;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();	
	}
	private async void DoubleToIntTapped(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new DoubleToIntConverterSamples());
	}

    
}

