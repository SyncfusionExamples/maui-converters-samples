namespace BoolToOpacityConverter.Samples;

public partial class BoolToOpacityConverterSamplePage : ContentPage
{
	public BoolToOpacityConverterSamplePage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		if (this.botImage.Opacity == 1)
			this.botImage.Opacity = 0;
		else
			this.botImage.Opacity = 1;
	}
}