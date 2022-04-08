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

namespace IsListNotNullOrEmptyConverter.ViewModel
{
    internal class IsListNotNullOrEmptyViewModel : INotifyPropertyChanged
    {
        private string newItem = "New Item";
        public IsListNotNullOrEmptyViewModel()
        {
            AddCollectionCommand = new Command(() => ListOfItems.Add(newItem));
            ClearCollectionCommand = new Command(ListOfItems.Clear);
            ListOfItems.CollectionChanged += HandleCollectionChanged;
        }
        private ObservableCollection<string> listOfItems = new ObservableCollection<string>()
            {
            "Item 0",
            "Item 1",
            "Item 2",
            "Item 3",

            };

        public ObservableCollection<string> ListOfItems
        {
            get { return listOfItems; }
            set { listOfItems = value;}
        }

        
        public ICommand ClearCollectionCommand { get; }
        public ICommand AddCollectionCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;


        private void HandleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(ListOfItems));
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName="")
        {
            if(propertyName != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
