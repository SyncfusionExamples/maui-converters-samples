using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUIValueConverters;

public partial class DoubleToIntConverterPage : ContentPage
{
	public DoubleToIntConverterPage()
	{
		InitializeComponent();
	}
}

public class DoubleToIntViewModel : INotifyPropertyChanged
{
    private double _entryValue;

    public double EntryValue
    {
        get { return _entryValue; }
        set { _entryValue = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        if (PropertyChanged != null)
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}



