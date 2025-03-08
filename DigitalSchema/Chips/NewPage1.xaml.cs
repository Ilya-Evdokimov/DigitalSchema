using Microsoft.Maui.Controls.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DigitalSchema.Chips
{
    public partial class NewPage1 : ContentView, INotifyPropertyChanged
    {
        private Color _InputValues_01 = Colors.Transparent;
        private Color _InputValues_02 = Colors.Transparent;
        private Color _InputValues_03 = Colors.Transparent;
        private Color _InputValues_04 = Colors.Transparent;
        private Color _OutputValues;

        public Color InputValues_01
        {
            get => _InputValues_01;
            set
            {
                _InputValues_01 = value;
                OnPropertyChanged();
                ProcessedValues_NewPage1();
            }
        }
        public Color InputValues_02
        {
            get => _InputValues_02;
            set
            {
                _InputValues_02 = value;
                OnPropertyChanged();
                ProcessedValues_NewPage1();
            }
        }
        public Color InputValues_03
        {
            get => _InputValues_03;
            set
            {
                _InputValues_03 = value;
                OnPropertyChanged();
                ProcessedValues_NewPage1();
            }
        }
        public Color InputValues_04
        {
            get => _InputValues_04;
            set
            {
                _InputValues_04 = value;
                OnPropertyChanged();
                ProcessedValues_NewPage1();
            }
        }
        public event EventHandler<Color> ColorChanged;
        public Color OutputValues
        {
            get => _OutputValues;
            set
            {
                if (_OutputValues != value)
                {
                    _OutputValues = value;
                    OnPropertyChanged();
                    ColorChanged?.Invoke(this, value);
                }
            }
        }

        public void ProcessedValues_NewPage1()
        {
            int outputValue = DigitalConverter(InputValues_01) * DigitalConverter(InputValues_02) * DigitalConverter(InputValues_03) * DigitalConverter(InputValues_04);
            OutputValues = outputValue == 1 ? Colors.Transparent : Colors.Red;
        }

        public int DigitalConverter(Color inputValues)
        {
            return inputValues == Colors.Transparent ? 0 : 1;
        }

        public event EventHandler<Ellipse> EllipseTapped;

        public void OnEllipseTapped(object sender, EventArgs e)
        {
            if (sender is Ellipse ellipse)
            {
                EllipseTapped?.Invoke(this, ellipse);
            }

            if (e is TappedEventArgs tapEventArgs && tapEventArgs.Parameter is string propertyName)
            {
                switch (propertyName)
                {
                    case "s_InputValues_01":
                        InputValues_01 = InputValues_01 == Colors.Transparent ? Colors.Red : Colors.Transparent;
                        break;
                    case "s_InputValues_02":
                        InputValues_02 = InputValues_02 == Colors.Transparent ? Colors.Red : Colors.Transparent;
                        break;
                    case "s_InputValues_03":
                        InputValues_03 = InputValues_03 == Colors.Transparent ? Colors.Red : Colors.Transparent;
                        break;
                    case "s_InputValues_04":
                        InputValues_04 = InputValues_04 == Colors.Transparent ? Colors.Red : Colors.Transparent;
                        break;
                    default:
                        break;
                }
            }
        }

        public event EventHandler<Ellipse> ExitEllipseTapped;

        public void OnExitEllipseTapped(object sender, EventArgs e)
        {
            if (sender is Ellipse ellipse)
            {
                ExitEllipseTapped?.Invoke(this, ellipse);
            }
        }

        public NewPage1()
        {
            InitializeComponent();
            BindingContext = this;
            ProcessedValues_NewPage1();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}