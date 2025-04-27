using Microsoft.Maui.Controls.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DigitalSchema.Chips;

public partial class ChipSmalTT : ContentView, INotifyPropertyChanged
{
    private Color _InputValues_S = Colors.Red;
    private Color _InputValues_R = Colors.Red;
    private Color _InputValues_D = Colors.Red;
    private Color _InputValues_C = Colors.Transparent;
    private Color _OutputValues = Colors.Transparent;
    private Color _OutputValues_Inv = Colors.Red;

    public Color InputValues_S
    {
        get => _InputValues_S;
        set
        {
            _InputValues_S = value;
            OnPropertyChanged();
            ProcessedValues_ChipTT();
        }
    }
    public Color InputValues_R
    {
        get => _InputValues_R;
        set
        {
            _InputValues_R = value;
            OnPropertyChanged();
            ProcessedValues_ChipTT();
        }
    }
    public Color InputValues_D
    {
        get => _InputValues_D;
        set
        {
            _InputValues_D = value;
            OnPropertyChanged();
            ProcessedValues_ChipTT();
        }
    }
    public Color InputValues_C
    {
        get => _InputValues_C;
        set
        {
            _InputValues_C = value;
            OnPropertyChanged();
            ProcessedValues_ChipTT();
        }
    }
    public event EventHandler<Color> ColorChanged;
    public Color OutputValues
    {
        get => _OutputValues;
        set
        {
            _OutputValues = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color OutputValues_Inv
    {
        get => _OutputValues_Inv;
        set
        {
            _OutputValues_Inv = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public void ProcessedValues_ChipTT()
    {
        if (DigitalConverter(InputValues_C) == 1 && DigitalConverter(InputValues_S) == 1 && DigitalConverter(InputValues_R) == 1)
        {
            if(DigitalConverter(InputValues_D) == 1)
            {
                OutputValues = Colors.Red;
                OutputValues_Inv = Colors.Transparent;
            }
            else
            {
                OutputValues = Colors.Transparent;
                OutputValues_Inv = Colors.Red;
            }
        }
        else if (DigitalConverter(InputValues_C) == 0)
        {
            if (DigitalConverter(InputValues_S) == 0 && DigitalConverter(InputValues_R) == 1)
            {
                OutputValues = Colors.Red;
                OutputValues_Inv = Colors.Transparent;
            }
            else if (DigitalConverter(InputValues_S) == 1 && DigitalConverter(InputValues_R) == 0)
            {
                OutputValues_Inv = Colors.Red;
                OutputValues = Colors.Transparent;
            }
        }
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
    public ChipSmalTT()
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