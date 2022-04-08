namespace NumericToBoolConverter;
using System.Windows.Input;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();	
	}
	

    private async void NumericToBoolTapped(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new NumericToBoolSamples());
	}

   
}

