using System.ComponentModel;
using System.Drawing;

namespace SimpleColorTool
{
    class ColorArgb : INotifyPropertyChanged
    {
        #region Private Fields
        private int _r;
        private int _g;
        private int _b;
        private int _a = 0;
        private Color _color = new Color();
        #endregion

        #region Calculated Fields
        public string ColorRGB =>
            $"rgb({Red.ToString()},{Green.ToString()},{Blue.ToString()})";
        public string ColorRGBA =>
            $"argb({Alpha.ToString()},{Red.ToString()},{Green.ToString()},{Blue.ToString()})";
        public string ColorHEXFULL =>
            $"#{Red.ToString("X")}{Green.ToString("X")}{Blue.ToString("X")}";
        public string ColorHEX =>
            $"{Red.ToString("X")}{Green.ToString("X")}{Blue.ToString("X")}";
        #endregion

        #region Properties
        public Color Color => _color;
        public int Alpha
        {
            get { return _a; }
            set
            {
                if (_a != value)
                {
                    _a = value;
                    SetColor();
                    OnPropertyChange("Alpha");
                }
            }
        }
        public int Red
        {
            get { return _r; }
            set
            {
                if (_r != value)
                {
                    _r = value;
                    SetColor();
                    OnPropertyChange("Red");
                }
            }
        }

        public int Green
        {
            get { return _g; }
            set
            {
                if (_g != value)
                {
                    _g = value;
                    SetColor();
                    OnPropertyChange("Green");
                }
            }
        }

        public int Blue
        {
            get { return _b; }
            set
            {
                if (_b != value)
                {
                    _b = value;
                    SetColor();
                    OnPropertyChange("Blue");
                }
            }
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods
        protected virtual void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SetColor()
        {
            int colorValue = 0;

            colorValue |= _a;
            colorValue <<= 8;
            colorValue |= _r;
            colorValue <<= 8;
            colorValue |= _g;
            colorValue <<= 8;
            colorValue |= _b;

            _color = Color.FromArgb(colorValue);
        }

        public void SetARGB(int argb)
        {
            Alpha = (argb >> 24) & 255;
            Red = (argb >> 16) & 255;
            Green = (argb >> 8) & 255;
            Blue = argb & 255;
        }
        #endregion
    }
}
