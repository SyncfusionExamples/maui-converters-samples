namespace BrushToColorConverter;

public partial class FrontPage : ContentPage
{
	public FrontPage()
	{
		InitializeComponent();
	}

    private async void BrushToColorConverterButtonClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new BrushToColorPage());
    }

    
    
   
}