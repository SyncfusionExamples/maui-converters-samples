namespace CompareCoverter;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	
	private async void CompareConverterButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new CompareConverterPage());
	}
	
}

