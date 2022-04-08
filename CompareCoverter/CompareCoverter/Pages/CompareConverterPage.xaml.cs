namespace CompareCoverter;

public partial class CompareConverterPage : ContentPage
{
	public CompareConverterPage()
	{
		InitializeComponent();

		labelString.Text = Resources["comparingValue"].ToString();
	}
}