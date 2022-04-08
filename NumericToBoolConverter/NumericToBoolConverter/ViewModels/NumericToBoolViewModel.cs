using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NumericToBoolConverter.ViewModels
{
    public class NumericToBoolViewModel : INotifyPropertyChanged
    {
        private double _entryValue;

        public double EntryValue
        {
            get { return _entryValue; }
            set { _entryValue = value; OnPropertyChanged(); }
        }

      
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
