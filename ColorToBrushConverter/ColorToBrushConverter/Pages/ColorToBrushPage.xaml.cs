namespace ColorToBrushConverter;

public partial class ColorToBrushPage : ContentPage
{
	public ColorToBrushPage()
	{
		InitializeComponent();
	}
	private void ChangeColorClicked(object sender, EventArgs e)
	{
		byte red = (byte)redSlider.Value;
		byte green = (byte)greenSlider.Value;
		byte blue = (byte)blueSlider.Value;		
		ColorBrush.BackgroundColor = Color.FromRgb(red, green, blue);
	}
	private void BackgroundChange(object sender, EventArgs e)
	{
		byte red = (byte)redSlider.Value;
		byte green = (byte)greenSlider.Value;
		byte blue = (byte)blueSlider.Value;		
		BrushColor.Background = new SolidColorBrush(Color.FromRgb(red, green, blue));
	}

}