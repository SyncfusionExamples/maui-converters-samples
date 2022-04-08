namespace ColorToColorForTextConverter;

public partial class FrontPage : ContentPage
{
	public FrontPage()
	{
		InitializeComponent();
	}

    private async void ColorToColorForTextConverterButtonClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new ColorToColorForTextPage());
    }
   
}