using Microsoft.Maui.Controls.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DigitalSchema.Chips;

public partial class Chip3ORTwo : ContentView, INotifyPropertyChanged
{
    private Color _InputValues_01_01 = Colors.Red;
    private Color _InputValues_02_01 = Colors.Red;
    private Color _InputValues_03_01 = Colors.Red;
    private Color _OutputValues_01;
    private Color _InputValues_01_02 = Colors.Red;
    private Color _InputValues_02_02 = Colors.Red;
    private Color _InputValues_03_02 = Colors.Red;
    private Color _OutputValues_02;
    private Color _InputValues_01_03 = Colors.Red;
    private Color _InputValues_02_03 = Colors.Red;
    private Color _InputValues_03_03 = Colors.Red;
    private Color _OutputValues_03;

    public Color InputValues_01_01
    {
        get => _InputValues_01_01;
        set
        {
            _InputValues_01_01 = value;
            OnPropertyChanged();
            ProcessedValues_Chip3ORTwo();
        }
    }
    public Color InputValues_02_01
    {
        get => _InputValues_02_01;
        set
        {
            _InputValues_02_01 = value;
            OnPropertyChanged();
            ProcessedValues_Chip3ORTwo();
        }
    }
    public Color InputValues_03_01
    {
        get => _InputValues_03_01;
        set
        {
            _InputValues_03_01 = value;
            OnPropertyChanged();
            ProcessedValues_Chip3ORTwo();
        }
    }
    public Color InputValues_01_02
    {
        get => _InputValues_01_02;
        set
        {
            _InputValues_01_02 = value;
            OnPropertyChanged();
            ProcessedValues_Chip3ORTwo();
        }
    }
    public Color InputValues_02_02
    {
        get => _InputValues_02_02;
        set
        {
            _InputValues_02_02 = value;
            OnPropertyChanged();
            ProcessedValues_Chip3ORTwo();
        }
    }
    public Color InputValues_03_02
    {
        get => _InputValues_03_02;
        set
        {
            _InputValues_03_02 = value;
            OnPropertyChanged();
            ProcessedValues_Chip3ORTwo();
        }
    }
    public Color InputValues_01_03
    {
        get => _InputValues_01_01;
        set
        {
            _InputValues_01_01 = value;
            OnPropertyChanged();
            ProcessedValues_Chip3ORTwo();
        }
    }
    public Color InputValues_02_03
    {
        get => _InputValues_02_03;
        set
        {
            _InputValues_02_03 = value;
            OnPropertyChanged();
            ProcessedValues_Chip3ORTwo();
        }
    }
    public Color InputValues_03_03
    {
        get => _InputValues_03_03;
        set
        {
            _InputValues_03_03 = value;
            OnPropertyChanged();
            ProcessedValues_Chip3ORTwo();
        }
    }

    public event EventHandler<Color> ColorChanged;
    public Color OutputValues_01
    {
        get => _OutputValues_01;
        set
        {
            if (_OutputValues_01 != value)
            {
                _OutputValues_01 = value;
                OnPropertyChanged();
                ColorChanged?.Invoke(this, value);
            }
        }
    }
    public Color OutputValues_02
    {
        get => _OutputValues_02;
        set
        {
            if (_OutputValues_02 != value)
            {
                _OutputValues_02 = value;
                OnPropertyChanged();
                ColorChanged?.Invoke(this, value);
            }
        }
    }
    public Color OutputValues_03
    {
        get => _OutputValues_03;
        set
        {
            if (_OutputValues_03 != value)
            {
                _OutputValues_03 = value;
                OnPropertyChanged();
                ColorChanged?.Invoke(this, value);
            }
        }
    }
    public void ProcessedValues_Chip3ORTwo()
    {
        int outputValue = DigitalConverter(InputValues_01_01) + DigitalConverter(InputValues_02_01) + DigitalConverter(InputValues_03_01);
        OutputValues_01 = outputValue >= 1 ? Colors.Transparent : Colors.Red;
        outputValue = DigitalConverter(InputValues_01_02) + DigitalConverter(InputValues_02_02) + DigitalConverter(InputValues_03_02);
        OutputValues_02 = outputValue >= 1 ? Colors.Transparent : Colors.Red;
        outputValue = DigitalConverter(InputValues_01_03) + DigitalConverter(InputValues_02_03) + DigitalConverter(InputValues_03_03);
        OutputValues_03 = outputValue >= 1 ? Colors.Transparent : Colors.Red;
        return;
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
    }
    public event EventHandler<Ellipse> ExitEllipseTapped;
    public void OnExitEllipseTapped(object sender, EventArgs e)
    {
        if (sender is Ellipse ellipse)
        {
            ExitEllipseTapped?.Invoke(this, ellipse);
        }
    }
    public Chip3ORTwo()
	{
		InitializeComponent();
		BindingContext = this;
	}
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}