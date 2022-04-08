namespace ColorToColorForTextConverter;

public partial class ColorToColorForTextPage : ContentPage
{
	public ColorToColorForTextPage()
	{
		InitializeComponent();
	}

    private void ChangeColorClicked(object sender, EventArgs e)
	{
		byte red = (byte)redSlider.Value;
		byte green = (byte)greenSlider.Value;
		byte blue = (byte)blueSlider.Value;		
		button.BackgroundColor = Color.FromRgb(red, green, blue);
	}
}