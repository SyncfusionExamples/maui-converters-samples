namespace MultiConverter;
using System.Windows.Input;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();	
	}
	
    private async void MultiConverterTapped(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MultiConverterSamplePage());
	}

}

