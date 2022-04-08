namespace InverseOpacityConverter;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void InverseOpacityClicked(object sender, EventArgs e)
    {
       Navigation.PushAsync(new InverseOpacityPage());
    }

}

