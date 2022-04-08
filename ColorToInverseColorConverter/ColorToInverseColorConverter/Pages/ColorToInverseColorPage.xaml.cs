namespace ColorToInverseColorConverter;

public partial class ColorToInverseColorPage : ContentPage
{
   
    public ColorToInverseColorPage()
	{
		InitializeComponent();
	}
	
	private void ChangeColorClicked(object sender, EventArgs e)
	{
		byte red = (byte)redSlider.Value;
		byte green = (byte)greenSlider.Value;
		byte blue = (byte)blueSlider.Value;		
		InverseColor.BackgroundColor = Color.FromRgb(red, green, blue);
	}

}