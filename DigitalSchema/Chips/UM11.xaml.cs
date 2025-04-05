using Microsoft.Maui.Controls.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DigitalSchema.Chips;

public partial class UM11 : ContentView, INotifyPropertyChanged
{
    private Color _SyncSignal = Colors.Transparent;
    private Color _Diod_01 = Colors.Transparent;
    private Color _Diod_02 = Colors.Transparent;
    private Color _Diod_03 = Colors.Transparent;
    private Color _Diod_04 = Colors.Transparent;
    private Color _Diod_05 = Colors.Transparent;
    private Color _Diod_06 = Colors.Transparent;
    private Color _Diod_07 = Colors.Transparent;
    private Color _Diod_08 = Colors.Transparent;

    private Color _Button_01A = Colors.Transparent;
    private Color _Button_01B = Colors.Red;
    private Color _Button_02A = Colors.Transparent;
    private Color _Button_02B = Colors.Red;
    private Color _Button_03A = Colors.Transparent;
    private Color _Button_03B = Colors.Red;
    private Color _Button_04A = Colors.Transparent;
    private Color _Button_04B = Colors.Red;
    private Color _Button_05A = Colors.Transparent;
    private Color _Button_05B = Colors.Red;
    private Color _Button_06A = Colors.Transparent;
    private Color _Button_06B = Colors.Red;
    private Color _Button_07A = Colors.Transparent;
    private Color _Button_07B = Colors.Red;
    private Color _Button_08A = Colors.Transparent;
    private Color _Button_08B = Colors.Red;

    private bool _switch1;
    private bool _switch2;
    private bool _switch3;
    private bool _switch4;
    private bool _switch5;
    private bool _switch6;
    private bool _switch7;
    private bool _switch8;
    public bool Switch1
    {
        get => _switch1;
        set
        {
            _switch1 = value;
            OnPropertyChanged();
            Button_01A = Button_01A == Colors.Transparent ? Colors.Red : Colors.Transparent;
            Button_01B = Button_01B == Colors.Transparent ? Colors.Red : Colors.Transparent;
        }
    }
    public bool Switch2
    {
        get => _switch2;
        set
        {
            _switch2 = value;
            OnPropertyChanged();
            Button_02A = Button_02A == Colors.Transparent ? Colors.Red : Colors.Transparent;
            Button_02B = Button_02B == Colors.Transparent ? Colors.Red : Colors.Transparent;
        }
    }
    public bool Switch3
    {
        get => _switch3;
        set
        {
            _switch3 = value;
            OnPropertyChanged();
            Button_03A = Button_03A == Colors.Transparent ? Colors.Red : Colors.Transparent;
            Button_03B = Button_03B == Colors.Transparent ? Colors.Red : Colors.Transparent;
        }
    }
    public bool Switch4
    {
        get => _switch4;
        set
        {
            _switch4 = value;
            OnPropertyChanged();
            Button_04A = Button_04A == Colors.Transparent ? Colors.Red : Colors.Transparent;
            Button_04B = Button_04B == Colors.Transparent ? Colors.Red : Colors.Transparent;
        }
    }

    public bool Switch5
    {
        get => _switch5;
        set
        {
            _switch5 = value;
            OnPropertyChanged();
            Button_05A = Button_05A == Colors.Transparent ? Colors.Red : Colors.Transparent;
            Button_05B = Button_05B == Colors.Transparent ? Colors.Red : Colors.Transparent;
        }
    }
    public bool Switch6
    {
        get => _switch6;
        set
        {
            _switch6 = value;
            OnPropertyChanged();
            Button_06A = Button_06A == Colors.Transparent ? Colors.Red : Colors.Transparent;
            Button_06B = Button_06B == Colors.Transparent ? Colors.Red : Colors.Transparent;
        }
    }
    public bool Switch7
    {
        get => _switch7;
        set
        {
            _switch7 = value;
            OnPropertyChanged();
            Button_07A = Button_07A == Colors.Transparent ? Colors.Red : Colors.Transparent;
            Button_07B = Button_07B == Colors.Transparent ? Colors.Red : Colors.Transparent;
        }
    }
    public bool Switch8
    {
        get => _switch8;
        set
        {
            _switch8 = value;
            OnPropertyChanged();
            Button_08A = Button_08A == Colors.Transparent ? Colors.Red : Colors.Transparent;
            Button_08B = Button_08B == Colors.Transparent ? Colors.Red : Colors.Transparent;
        }
    }

    public event EventHandler<Color> ColorChanged;
    public Color SyncSignal
    {
        get => _SyncSignal;
        set
        {
            _SyncSignal = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    // ============================= Êíîïêè
    public Color Button_01A
    {
        get => _Button_01A;
        set
        {
            _Button_01A = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_01B
    {
        get => _Button_01B;
        set
        {
            _Button_01B = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_02A
    {
        get => _Button_02A;
        set
        {
            _Button_02A = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_02B
    {
        get => _Button_02B;
        set
        {
            _Button_02B = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_03A
    {
        get => _Button_03A;
        set
        {
            _Button_03A = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_03B
    {
        get => _Button_03B;
        set
        {
            _Button_03B = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_04A
    {
        get => _Button_04A;
        set
        {
            _Button_04A = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_04B
    {
        get => _Button_04B;
        set
        {
            _Button_04B = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_05A
    {
        get => _Button_05A;
        set
        {
            _Button_05A = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_05B
    {
        get => _Button_05B;
        set
        {
            _Button_05B = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_06A
    {
        get => _Button_06A;
        set
        {
            _Button_06A = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_06B
    {
        get => _Button_06B;
        set
        {
            _Button_06B = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_07A
    {
        get => _Button_07A;
        set
        {
            _Button_07A = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_07B
    {
        get => _Button_07B;
        set
        {
            _Button_07B = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_08A
    {
        get => _Button_08A;
        set
        {
            _Button_08A = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Button_08B
    {
        get => _Button_08B;
        set
        {
            _Button_08B = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    // =============================
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
    private async void OnButtonPressed(object sender, EventArgs e)
    {
        SyncSignal = Colors.Red;
        await Task.Delay(1000);
        SyncSignal = Colors.Transparent;
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