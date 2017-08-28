using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleColorTool
{
    public partial class MainWindow : Form
    {
        private ColorArgb _colorHovered;
        private ColorArgb _colorClicked;
        private Bitmap _colorWheelImage;
        private Circle _colorCircle;

        public MainWindow()
        {
            InitializeComponent();

            _colorHovered = new ColorArgb
            {
                Alpha = 255,
                Red = 255,
                Blue = 255,
                Green = 255
            };

            _colorClicked = new ColorArgb
            {
                Alpha = 255,
                Red = 255,
                Blue = 255,
                Green = 255
            };
            _colorWheelImage = (Bitmap)colorWheelPicture.Image;
            _colorCircle = new Circle(new Point(colorWheelPicture.Size.Width / 2, (colorWheelPicture.Height / 2)), colorWheelPicture.Width / 2);

            hoverAlphaScrollBar.DataBindings.Add("Value", _colorHovered, "Alpha", false, DataSourceUpdateMode.OnPropertyChanged);
            hoverRedScrollBar.DataBindings.Add("Value", _colorHovered, "Red", false, DataSourceUpdateMode.OnPropertyChanged);
            hoverGreenScrollBar.DataBindings.Add("Value", _colorHovered, "Green", false, DataSourceUpdateMode.OnPropertyChanged);
            hoverBlueScrollBar.DataBindings.Add("Value", _colorHovered, "Blue", false, DataSourceUpdateMode.OnPropertyChanged);

            hoverRgbLabel.DataBindings.Add("Text", _colorHovered, "ColorRGB", false, DataSourceUpdateMode.OnPropertyChanged);
            hoverArgbLabel.DataBindings.Add("Text", _colorHovered, "ColorRGBA", false, DataSourceUpdateMode.OnPropertyChanged);
            hoverHexLabel1.DataBindings.Add("Text", _colorHovered, "ColorHEXFULL", false, DataSourceUpdateMode.OnPropertyChanged);
            hoverHexLabel2.DataBindings.Add("Text", _colorHovered, "ColorHEX", false, DataSourceUpdateMode.OnPropertyChanged);

            hoverColorPreview.DataBindings.Add("BackColor", _colorHovered, "Color", false, DataSourceUpdateMode.OnPropertyChanged);


            clickAlphaScrollBar.DataBindings.Add("Value", _colorClicked, "Alpha", false, DataSourceUpdateMode.OnPropertyChanged);
            clickRedScrollBar.DataBindings.Add("Value", _colorClicked, "Red", false, DataSourceUpdateMode.OnPropertyChanged);
            clickGreenScrollBar.DataBindings.Add("Value", _colorClicked, "Green", false, DataSourceUpdateMode.OnPropertyChanged);
            clickBlueScrollBar.DataBindings.Add("Value", _colorClicked, "Blue", false, DataSourceUpdateMode.OnPropertyChanged);

            clickRgbLabel.DataBindings.Add("Text", _colorClicked, "ColorRGB", false, DataSourceUpdateMode.OnPropertyChanged);
            clickArgbLabel.DataBindings.Add("Text", _colorClicked, "ColorRGBA", false, DataSourceUpdateMode.OnPropertyChanged);
            clickHexLabel1.DataBindings.Add("Text", _colorClicked, "ColorHEXFULL", false, DataSourceUpdateMode.OnPropertyChanged);
            clickHexLabel2.DataBindings.Add("Text", _colorClicked, "ColorHEX", false, DataSourceUpdateMode.OnPropertyChanged);

            clickColorPreview.DataBindings.Add("BackColor", _colorClicked, "Color", false, DataSourceUpdateMode.OnPropertyChanged);

            colorWheelPicture.Select();
        }

        private void Copy_Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string copiedText = "";

            switch (button.Name)
            {
                case "copyHoveredColorRgbBtn":
                    copiedText = hoverRgbLabel.Text;
                    break;
                case "copyHoveredColorArgbBtn":
                    copiedText = hoverArgbLabel.Text;
                    break;
                case "copyHoveredColorHexBtn1":
                    copiedText = hoverHexLabel1.Text;
                    break;
                case "copyHoveredColorHexBtn2":
                    copiedText = hoverHexLabel2.Text;
                    break;
                case "copyClickedColorRgbBtn":
                    copiedText = clickRgbLabel.Text;
                    break;
                case "copyClickedColorArgbBtn":
                    copiedText = clickArgbLabel.Text;
                    break;
                case "copyClickedColorHexBtn1":
                    copiedText = clickHexLabel1.Text;
                    break;
                case "copyClickedColorHexBtn2":
                    copiedText = clickHexLabel2.Text;
                    break;
            }

            if (string.IsNullOrEmpty(copiedText) == false)
            {
                Clipboard.SetText(copiedText);
                toolStripStatusLabel1.Text = "copied: " + copiedText;
            }
        }

        private void ColorWheel_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Color pixel = _colorWheelImage.GetPixel(e.X, e.Y);

                if (_colorCircle.IsPointInCircle(new Point(e.X, e.Y)))
                {
                    _colorHovered.SetARGB(pixel.ToArgb());
                }
            }
            catch { }
        }

        private void ColorWheel_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = e as MouseEventArgs;

            try
            {
                Color pixel = _colorWheelImage.GetPixel(mouseEvent.X, mouseEvent.Y);

                if (_colorCircle.IsPointInCircle(new Point(mouseEvent.X, mouseEvent.Y)))
                {
                    _colorClicked.SetARGB(pixel.ToArgb());
                }
            }
            catch { }
        }
    }
}
