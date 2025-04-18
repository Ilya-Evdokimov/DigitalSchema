using Microsoft.Maui.Controls.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DigitalSchema.Chips;

public partial class ChipAndKE : ContentView, INotifyPropertyChanged
{
    private Color _InputValues_01 = Colors.Red;
    private Color _InputValues_02 = Colors.Red;
    private Color _InputValues_03 = Colors.Red;
    private Color _InputValues_04 = Colors.Red;
    private Color _OutputValues;

    public Color InputValues_01
    {
        get => _InputValues_01;
        set
        {
            _InputValues_01 = value;
            OnPropertyChanged();
            ProcessedValues_ChipAndKE();
        }
    }
    public Color InputValues_02
    {
        get => _InputValues_02;
        set
        {
            _InputValues_02 = value;
            OnPropertyChanged();
            ProcessedValues_ChipAndKE();
        }
    }
    public Color InputValues_03
    {
        get => _InputValues_03;
        set
        {
            _InputValues_03 = value;
            OnPropertyChanged();
            ProcessedValues_ChipAndKE();
        }
    }
    public Color InputValues_04
    {
        get => _InputValues_04;
        set
        {
            _InputValues_04 = value;
            OnPropertyChanged();
            ProcessedValues_ChipAndKE();
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
    public void ProcessedValues_ChipAndKE()
    {
        int outputValue = DigitalConverter(InputValues_01) * DigitalConverter(InputValues_02) * DigitalConverter(InputValues_03) * DigitalConverter(InputValues_04);
        OutputValues = outputValue == 0 ? Colors.Transparent : Colors.Red;      
    }

    public ChipAndKE()
	{
		InitializeComponent();
        BindingContext = this;
        ProcessedValues_ChipAndKE();
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