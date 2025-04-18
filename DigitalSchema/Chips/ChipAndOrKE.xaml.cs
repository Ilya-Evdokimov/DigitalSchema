using Microsoft.Maui.Controls.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DigitalSchema.Chips;

public partial class ChipAndOrKE : ContentView, INotifyPropertyChanged
{
    private Color _InputValues01 = Colors.Red;
    private Color _InputValues02 = Colors.Red;
    private Color _InputValues03 = Colors.Red;
    private Color _InputValues04 = Colors.Red;
    private Color _InputValues05 = Colors.Red;
    private Color _InputValues06 = Colors.Red;
    private Color _InputValues07 = Colors.Red;
    private Color _InputValues08 = Colors.Red;
    private Color _InputValues09 = Colors.Red;
    private Color _InputValues10 = Colors.Red;
    private Color _OutputValues01;
    private Color _OutputValues02;

    public Color InputValues01
    {
        get => _InputValues01;
        set
        {
            _InputValues01 = value;
            OnPropertyChanged();
            ProcessedValues_ChipAndOrKE();
        }
    }
    public Color InputValues02
    {
        get => _InputValues02;
        set
        {
            _InputValues02 = value;
            OnPropertyChanged();
            ProcessedValues_ChipAndOrKE();
        }
    }
    public Color InputValues03
    {
        get => _InputValues03;
        set
        {
            _InputValues03 = value;
            OnPropertyChanged();
            ProcessedValues_ChipAndOrKE();
        }
    }
    public Color InputValues04
    {
        get => _InputValues04;
        set
        {
            _InputValues04 = value;
            OnPropertyChanged();
            ProcessedValues_ChipAndOrKE();
        }
    }
    public Color InputValues05
    {
        get => _InputValues05;
        set
        {
            _InputValues05 = value;
            OnPropertyChanged();
            ProcessedValues_ChipAndOrKE();
        }
    }
    public Color InputValues06
    {
        get => _InputValues06;
        set
        {
            _InputValues06 = value;
            OnPropertyChanged();
            ProcessedValues_ChipAndOrKE();
        }
    }
    public Color InputValues07
    {
        get => _InputValues07;
        set
        {
            _InputValues07 = value;
            OnPropertyChanged();
            ProcessedValues_ChipAndOrKE();
        }
    }
    public Color InputValues08
    {
        get => _InputValues08;
        set
        {
            _InputValues08 = value;
            OnPropertyChanged();
            ProcessedValues_ChipAndOrKE();
        }
    }
    public Color InputValues09
    {
        get => _InputValues09;
        set
        {
            _InputValues09 = value;
            OnPropertyChanged();
            ProcessedValues_ChipAndOrKE();
        }
    }
    public Color InputValues10
    {
        get => _InputValues10;
        set
        {
            _InputValues10 = value;
            OnPropertyChanged();
            ProcessedValues_ChipAndOrKE();
        }
    }
    public event EventHandler<Color> ColorChanged;
    public Color OutputValues01
    {
        get => _OutputValues01;
        set
        {
            if (_OutputValues01 != value)
            {
                _OutputValues01 = value;
                OnPropertyChanged();
                ColorChanged?.Invoke(this, value);
            }
        }
    }
    public Color OutputValues02
    {
        get => _OutputValues02;
        set
        {
            if (_OutputValues02 != value)
            {
                _OutputValues02 = value;
                OnPropertyChanged();
                ColorChanged?.Invoke(this, value);
            }
        }
    }
    public void ProcessedValues_ChipAndOrKE()
    {
        int outputValue = DigitalConverter(InputValues01) * DigitalConverter(InputValues02) + DigitalConverter(InputValues03) * DigitalConverter(InputValues04);
        OutputValues01 = outputValue >= 1 ? Colors.Transparent : Colors.Red;
        outputValue = DigitalConverter(InputValues05) * DigitalConverter(InputValues06) + DigitalConverter(InputValues07) * DigitalConverter(InputValues08) + DigitalConverter(InputValues09) * DigitalConverter(InputValues10);
        OutputValues02 = outputValue >= 1 ? Colors.Transparent : Colors.Red;
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
    public int DigitalConverter(Color inputValues)
    {
        return inputValues == Colors.Transparent ? 0 : 1;
    }

    public ChipAndOrKE()
	{
		InitializeComponent();
        BindingContext = this;
        ProcessedValues_ChipAndOrKE();
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}