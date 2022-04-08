namespace ColorToInverseColorConverter;

public partial class FrontPage : ContentPage
{
	public FrontPage()
	{
		InitializeComponent();
	}

    private async void ColorToInverseColorConverterButtonClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new ColorToInverseColorPage());
    } 
   
}