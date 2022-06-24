using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUIValueConverters;

public partial class MultiConverterPage : ContentPage
{

	public MultiConverterPage()
	{
		InitializeComponent();
	}
}

public class MultiConverterViewModel : INotifyPropertyChanged
{
    private string enteredAnswer = String.Empty;

    public string EnteredAnswer
    {
        get => enteredAnswer;
        set
        {
            enteredAnswer = value;
            OnPropertyChanged();
        }

    }

    public event PropertyChangedEventHandler PropertyChanged;



    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        if (PropertyChanged != null)
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}


