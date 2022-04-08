namespace ColorToGrayScaleColorConverter;

public partial class FrontPage : ContentPage
{
	public FrontPage()
	{
		InitializeComponent();
	}

   
    private async void ColorToGrayScaleColorConverterButtonClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new ColorToGrayScaleColorPage());
    }
   
}