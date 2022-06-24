using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MAUIValueConverters;

public partial class IsListNotNullOrEmptyConverterPage : ContentPage
{

	public IsListNotNullOrEmptyConverterPage()
	{
		InitializeComponent();
	}

}

internal class IsListNotNullOrEmptyViewModel : INotifyPropertyChanged
{
    private string newItem = "Person";
    public IsListNotNullOrEmptyViewModel()
    {
        AddCollectionCommand = new Command(() => ListOfItems.Add(newItem));
        ClearCollectionCommand = new Command(ListOfItems.Clear);
        ListOfItems.CollectionChanged += HandleCollectionChanged;
    }
    private ObservableCollection<string> listOfItems = new ObservableCollection<string>()
            {
            "Person",
            "Person",
            "Person",
            };

    public ObservableCollection<string> ListOfItems
    {
        get { return listOfItems; }
        set { listOfItems = value; }
    }

    public ICommand ClearCollectionCommand { get; }
    public ICommand AddCollectionCommand { get; }

    public event PropertyChangedEventHandler PropertyChanged;


    private void HandleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        OnPropertyChanged(nameof(ListOfItems));
    }

    private void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        if (propertyName != null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}



