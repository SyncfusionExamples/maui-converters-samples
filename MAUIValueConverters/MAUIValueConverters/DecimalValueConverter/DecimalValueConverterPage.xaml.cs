using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUIValueConverters;

public partial class DecimalValueConverterPage : ContentPage
{

	public DecimalValueConverterPage()
	{
		InitializeComponent();
	}
}

public class DecimalValueConverterViewModel : INotifyPropertyChanged
{
	private double quantity;
    private string totalValue;

    public double Quantity
	{
		get { return quantity; }
		set 
		{
			quantity = value;
			OnPropertyChanged();
        }
	}

	public string TotalValue
	{
		get { return totalValue; }
		set 
		{ 
			totalValue = value;
			OnPropertyChanged();
		}
	}

	private string costPerStock = "1";

	public string CostPerStock
	{
		get { return costPerStock; }
		set 
		{
			if (value == "")
				costPerStock = "0";
			else
				costPerStock = value;
			OnPropertyChanged();
            
        }
	}

	
	public event PropertyChangedEventHandler PropertyChanged;

	public void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		if(propertyName == nameof(CostPerStock) || propertyName == nameof(Quantity))
            TotalValue = (Convert.ToDouble(CostPerStock) * Quantity).ToString();

    }
}


