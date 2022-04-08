using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ListToStringConverter
{ 
    public class ListToStringViewModel : INotifyPropertyChanged
    {
        public  ListToStringViewModel()
        {
            Notes = new ObservableCollection<string>();

            Notes.CollectionChanged += HandleCollectionChanged;

            AddCommand = new Command(() =>
            {
                Notes.Add(TheNote);
            });
        }

        private  string _theNote;

        public  string TheNote
        {
            get 
            { 
                return _theNote; 
            }
            set 
            { 
                _theNote = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<string> Notes { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void HandleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged(nameof(Notes));
        }
        public ICommand AddCommand { get; set; }
        
    }
}
