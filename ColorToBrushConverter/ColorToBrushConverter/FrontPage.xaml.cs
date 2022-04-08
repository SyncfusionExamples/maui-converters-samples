namespace ColorToBrushConverter;

public partial class FrontPage : ContentPage
{
	public FrontPage()
	{
		InitializeComponent();
	}

    private async void ColorToBrushConverterButtonClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new ColorToBrushPage());
    }
 
   
}