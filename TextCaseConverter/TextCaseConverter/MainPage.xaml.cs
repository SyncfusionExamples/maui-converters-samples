using TextCaseConverter;

namespace TextCaseConverter;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
		
	}

	
	private async void TextCaseButton_clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TextCaseConverterView());
	}

	
	
}

