using FormatStringConverter.Models;
using FormatStringConverter.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatStringConverter.ViewModels
{
    public class FormattableViewModel:INotifyPropertyChanged
    {
        private decimal _textValue = 43;
        private FormatModel formatProperty;
        public FormatModel FormatProperty
        { 
            get { return formatProperty; }
            set 
            {
                formatProperty = value;
                NotifyPropertyChanged("FormatProperty");
            }
        }
        public decimal TextValue
        {
            get { return _textValue; }
            set
            {
                _textValue = value;
                NotifyPropertyChanged("TextValue");
                this.FormatProperty = new FormatModel(_textValue);
            }
        }
         
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

       

        public FormattableViewModel()
        {
            this.FormatProperty = new FormatModel(TextValue);
            
        }
    }
}
