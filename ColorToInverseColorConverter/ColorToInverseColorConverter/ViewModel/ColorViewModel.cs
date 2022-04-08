using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorToInverseColorConverter
{
    public class ColorViewModel : INotifyPropertyChanged
    {
        private byte _redSliderValue = 0;

        public byte RedSliderValue
        {
            get
            {
                return _redSliderValue;
            }
            set
            {
                if (_redSliderValue == value)
                {
                    return;
                }
                _redSliderValue = value;
               
                OnPropertyChanged("RedSliderValue");
                UpdatePreviewColor();
            }
        }
        private byte _greenSliderValue = 0;

        public byte GreenSliderValue
        {
            get
            {
                return _greenSliderValue;
            }
            set
            {
                if (_greenSliderValue == value)
                {
                    return;
                }
                _greenSliderValue = value;
                OnPropertyChanged("GreenSliderValue");
                UpdatePreviewColor();
            }
        }
        private byte _blueSliderValue = 0;

        public byte BlueSliderValue
        {
            get
            {
                return _blueSliderValue;
            }
            set
            {
                if (_blueSliderValue == value)
                {
                    return;
                }
                _blueSliderValue = value;
                OnPropertyChanged("BlueSliderValue");
                UpdatePreviewColor();
            }
        }   

        private Color _previewColor = Colors.Black;
        public Color PreviewColor
        {
            get
            {
                return _previewColor;
            }
            set
            {
                if (_previewColor == value)
                {
                    return;
                }
                _previewColor = value;
                OnPropertyChanged("PreviewColor");
            }
        }
        public Color PreviewColorProperty { get; set; }

        private void UpdatePreviewColor()
        {
            byte red = RedSliderValue;
            byte green = GreenSliderValue;
            byte blue = BlueSliderValue;            
            this.PreviewColor = Color.FromRgb(red,green, blue);        
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
