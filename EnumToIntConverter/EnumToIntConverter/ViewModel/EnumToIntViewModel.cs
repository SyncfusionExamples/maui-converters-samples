using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnumToIntConverter
{
    public class EnumToIntViewModel
    {
        public List<Directions> AllDirections { get; set; }

        public EnumToIntViewModel()
        {
            this.AllDirections = new List<Directions>()
            { 
                Directions.North, 
                Directions.South,
                Directions.West,
                Directions.East};
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
