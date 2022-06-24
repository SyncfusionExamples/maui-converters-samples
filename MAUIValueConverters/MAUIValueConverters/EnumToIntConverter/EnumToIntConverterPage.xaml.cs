using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUIValueConverters;

public partial class EnumToIntConverterPage : ContentPage
{

	public EnumToIntConverterPage()
	{
		InitializeComponent();
	}
}

public class EnumToIntViewModel : INotifyPropertyChanged
{
    public IReadOnlyList<string> TotalFloor { get;} = Enum.GetNames(typeof(Floor));

    private Floor selectedFloor = Floor.Electronics;

    public Floor SelectedFloor
    {
        get
        {
            return selectedFloor;
        }
        set
        {
            selectedFloor = value;
            NotifyPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
}
public enum Floor
{
    Clothing = 0,
    Electronics = 1,
    Household = 2,
    Gym = 3,
    Food_Court = 4,
    Theatre =5,
}



