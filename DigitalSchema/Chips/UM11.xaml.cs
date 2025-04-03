using Microsoft.Maui.Controls.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DigitalSchema.Chips;

public partial class UM11 : ContentView, INotifyPropertyChanged
{
    private Color _Diod_01 = Colors.Transparent;
    private Color _Diod_02 = Colors.Transparent;
    private Color _Diod_03 = Colors.Transparent;
    private Color _Diod_04 = Colors.Transparent;
    private Color _Diod_05 = Colors.Transparent;
    private Color _Diod_06 = Colors.Transparent;
    private Color _Diod_07 = Colors.Transparent;
    private Color _Diod_08 = Colors.Transparent;
    public Color Diod_01
    {
        get => _Diod_01;
        set
        {
            _Diod_01 = value;
            OnPropertyChanged();
        }
    }
    public Color Diod_02
    {
        get => _Diod_02;
        set
        {
            _Diod_02 = value;
            OnPropertyChanged();
        }
    }
    public Color Diod_03
    {
        get => _Diod_03;
        set
        {
            _Diod_03 = value;
            OnPropertyChanged();
        }
    }
    public Color Diod_04
    {
        get => _Diod_04;
        set
        {
            _Diod_04 = value;
            OnPropertyChanged();
        }
    }
    public Color Diod_05
    {
        get => _Diod_05;
        set
        {
            _Diod_05 = value;
            OnPropertyChanged();
        }
    }
    public Color Diod_06
    {
        get => _Diod_06;
        set
        {
            _Diod_06 = value;
            OnPropertyChanged();
        }
    }
    public Color Diod_07
    {
        get => _Diod_07;
        set
        {
            _Diod_07 = value;
            OnPropertyChanged();
        }
    }
    public Color Diod_08
    {
        get => _Diod_08;
        set
        {
            _Diod_08 = value;
            OnPropertyChanged();
        }
    }
    public UM11()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public event EventHandler<Ellipse> ExitEllipseTapped;
    public void OnExitEllipseTapped(object sender, EventArgs e)
    {
        if (sender is Ellipse ellipse)
        {
            ExitEllipseTapped?.Invoke(this, ellipse);
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

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}