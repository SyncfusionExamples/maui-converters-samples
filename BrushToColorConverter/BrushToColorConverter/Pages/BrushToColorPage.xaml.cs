namespace BrushToColorConverter;

public partial class BrushToColorPage : ContentPage
{
	public BrushToColorPage()
	{
		InitializeComponent();
	}
	
	private void ChangeColorClicked(object sender, EventArgs e)
	{
		byte red = (byte)redSlider.Value;
		byte green = (byte)greenSlider.Value;
		byte blue = (byte)blueSlider.Value;		
		Color color = Color.FromRgb(red, green, blue);

		BrushColor.Background = new SolidColorBrush(color);

	}
	private void BackgroundColorChange(object sender, EventArgs e)
	{
		byte red = (byte)redSlider.Value;
		byte green = (byte)greenSlider.Value;
		byte blue = (byte)blueSlider.Value;		
		ColorBrush.BackgroundColor =Color.FromRgb(red, green, blue);		
	}
}