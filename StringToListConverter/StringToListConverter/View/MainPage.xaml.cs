namespace StringToListConverter;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void StringToListClicked(object sender, EventArgs e)
    {
		 Navigation.PushAsync(new StringToListPage());
    }

}

