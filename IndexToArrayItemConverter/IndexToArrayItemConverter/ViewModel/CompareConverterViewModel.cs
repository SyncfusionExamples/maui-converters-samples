using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using IndexToArrayItemConverter.Converters;

namespace IndexToArrayItemConverter.ViewModel
{
    internal class CompareConverterViewModel : INotifyPropertyChanged
    {
        private double rangeValue;

        public double RangeValue
        {
            get { return Math.Round(rangeValue,2); }
            set { rangeValue = value;
                OnPropertyChanged(); }
        }

        private string stringValue;

        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; OnPropertyChanged(); }
        }

        public static string Compare
        {
            get { return App.Current.MainPage.Resources["comparingValue"].ToString(); }
        }

        public CompareConverterViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyName="")
        {
            if(PropertyChanged != null)
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
