using Microsoft.Maui.Controls.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DigitalSchema.Chips;

public partial class Chip2And : ContentView, INotifyPropertyChanged
{
    private Color _InputValues_011 = Colors.Red;
    private Color _InputValues_021 = Colors.Red;
    private Color _InputValues_012 = Colors.Red;
    private Color _InputValues_022 = Colors.Red;
    private Color _InputValues_013 = Colors.Red;
    private Color _InputValues_023 = Colors.Red;
    private Color _InputValues_014 = Colors.Red;
    private Color _InputValues_024 = Colors.Red;
    private Color _OutputValues01;
    private Color _OutputValues02;
    private Color _OutputValues03;
    private Color _OutputValues04;

    public Color InputValues_011
    {
        get => _InputValues_011;
        set
        {
            _InputValues_011 = value;
            OnPropertyChanged();
            ProcessedValues_Chip2AND();
        }
    }
    public Color InputValues_021
    {
        get => _InputValues_021;
        set
        {
            _InputValues_021 = value;
            OnPropertyChanged();
            ProcessedValues_Chip2AND();
        }
    }
    public Color InputValues_012
    {
        get => _InputValues_012;
        set
        {
            _InputValues_012 = value;
            OnPropertyChanged();
            ProcessedValues_Chip2AND();
        }
    }
    public Color InputValues_022
    {
        get => _InputValues_022;
        set
        {
            _InputValues_022 = value;
            OnPropertyChanged();
            ProcessedValues_Chip2AND();
        }
    }
    public Color InputValues_013
    {
        get => _InputValues_013;
        set
        {
            _InputValues_013 = value;
            OnPropertyChanged();
            ProcessedValues_Chip2AND();
        }
    }
    public Color InputValues_023
    {
        get => _InputValues_023;
        set
        {
            _InputValues_023 = value;
            OnPropertyChanged();
            ProcessedValues_Chip2AND();
        }
    }
    public Color InputValues_014
    {
        get => _InputValues_014;
        set
        {
            _InputValues_014 = value;
            OnPropertyChanged();
            ProcessedValues_Chip2AND();
        }
    }
    public Color InputValues_024
    {
        get => _InputValues_024;
        set
        {
            _InputValues_024 = value;
            OnPropertyChanged();
            ProcessedValues_Chip2AND();
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
    public Color OutputValues03
    {
        get => _OutputValues03;
        set
        {
            if (_OutputValues03 != value)
            {
                _OutputValues03 = value;
                OnPropertyChanged();
                ColorChanged?.Invoke(this, value);
            }
        }
    }
    public Color OutputValues04
    {
        get => _OutputValues04;
        set
        {
            if (_OutputValues04 != value)
            {
                _OutputValues04 = value;
                OnPropertyChanged();
                ColorChanged?.Invoke(this, value);
            }
        }
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
    public void ProcessedValues_Chip2AND()
    {
        int outputValue = DigitalConverter(InputValues_011) * DigitalConverter(InputValues_021);
        OutputValues01 = outputValue == 0 ? Colors.Transparent : Colors.Red;
        outputValue = DigitalConverter(InputValues_012) * DigitalConverter(InputValues_022);
        OutputValues02 = outputValue == 0 ? Colors.Transparent : Colors.Red;
        outputValue = DigitalConverter(InputValues_013) * DigitalConverter(InputValues_023);
        OutputValues03 = outputValue == 0 ? Colors.Transparent : Colors.Red;
        outputValue = DigitalConverter(InputValues_014) * DigitalConverter(InputValues_024);
        OutputValues04 = outputValue == 0 ? Colors.Transparent : Colors.Red;
    }

    public Chip2And()
    {
        InitializeComponent();
        BindingContext = this;
        ProcessedValues_Chip2AND();
    }
    public int DigitalConverter(Color inputValues)
    {
        return inputValues == Colors.Transparent ? 0 : 1;
    }
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}