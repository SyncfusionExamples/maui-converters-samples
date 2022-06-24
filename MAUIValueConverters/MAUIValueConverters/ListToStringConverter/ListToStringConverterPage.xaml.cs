using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MAUIValueConverters;

public partial class ListToStringConverterPage : ContentPage
{

	public ListToStringConverterPage()
	{
		InitializeComponent();
	}

}

public class ListToStringViewModel : INotifyPropertyChanged
{
    public ListToStringViewModel()
    {
        CartList = new ObservableCollection<string>();

        CartList.CollectionChanged += HandleCollectionChanged;

        AddCommand = new Command(() =>
        {
            CartList.Add(Item);
            ItemsCount = CartList.Count().ToString();
        });
    }

    private string item;

    public string Item
    {
        get
        {
            return item;
        }
        set
        {
            item = value;
            NotifyPropertyChanged();
        }
    }

    private string itemsCount;

    public string ItemsCount
    {
        get { return itemsCount; }
        set 
        { 
            itemsCount = value;
            NotifyPropertyChanged();
        }
    }


    public ObservableCollection<string> CartList { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private void HandleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        NotifyPropertyChanged(nameof(CartList));
    }
    public ICommand AddCommand { get; set; }

}

