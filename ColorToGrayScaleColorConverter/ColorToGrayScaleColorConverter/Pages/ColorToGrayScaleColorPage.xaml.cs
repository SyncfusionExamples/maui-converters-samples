namespace ColorToGrayScaleColorConverter;

public partial class ColorToGrayScaleColorPage : ContentPage
{
	public ColorToGrayScaleColorPage()
	{
		InitializeComponent();
	}

	private void ChangeColorClicked(object sender, EventArgs e)
	{
		byte red = (byte)redSlider.Value;
		byte green = (byte)greenSlider.Value;
		byte blue = (byte)blueSlider.Value;		
		GrayScale.BackgroundColor = Color.FromRgb(red,green,blue);
	}


}