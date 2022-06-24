using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUIValueConverters;

public partial class NumberToBoolConverterPage : ContentPage
{

	public NumberToBoolConverterPage()
	{
		InitializeComponent();
	}
}

public class NumberToBoolViewModel : INotifyPropertyChanged
{

    private double entryValue;

    public double EntryValue
    {
        get { return entryValue; }
        set { entryValue = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler PropertyChanged;

	public void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}


