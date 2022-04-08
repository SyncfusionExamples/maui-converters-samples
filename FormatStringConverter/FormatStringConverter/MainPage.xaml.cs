using FormatStringConverter;

namespace FormatStringConverter;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void FormatStringButton_Clicked(object sender, EventArgs e)
	{
		 Navigation.PushAsync(new FormatStringConverterView());
	}

	
}

