namespace IndexToArrayItemConverter;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private async void IndexToArrayItemConverterButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new IndexToArrayItemConverterPage());
	}

   
	
}

