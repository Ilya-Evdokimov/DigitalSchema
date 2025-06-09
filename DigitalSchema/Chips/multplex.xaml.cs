using Microsoft.Maui.Controls.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DigitalSchema.Chips;

public partial class multplex : ContentView, INotifyPropertyChanged
{
    private Color _LD0 = Colors.Red;
    private Color _LD1 = Colors.Red;
    private Color _LD2 = Colors.Red;
    private Color _LD3 = Colors.Red;

    private Color _L1 = Colors.Red;
    private Color _L2 = Colors.Red;

    private Color _LD4 = Colors.Red;
    private Color _LD5 = Colors.Red;
    private Color _LD6 = Colors.Red;
    private Color _LD7 = Colors.Red;
    private Color _LERD1 = Colors.Red;
    private Color _LERD2 = Colors.Red;
    private Color _LOut0 = Colors.Red;
    private Color _LOut1 = Colors.Red;

    // Второй мультиплексор
    private Color _M1 = Colors.Red;
    private Color _M2 = Colors.Red;
    private Color _M3 = Colors.Red;

    private Color _MOut = Colors.Red;
    private Color _MOut_inv = Colors.Red;

    private Color _MD0 = Colors.Red;
    private Color _MD1 = Colors.Red;
    private Color _MD2 = Colors.Red;
    private Color _MD3 = Colors.Red;
    private Color _MD4 = Colors.Red;
    private Color _MD5 = Colors.Red;
    private Color _MD6 = Colors.Red;
    private Color _MD7 = Colors.Red;

    // Третий мультиплексор
    private Color _Inp0 = Colors.Red;
    private Color _Inp1 = Colors.Red;
    private Color _Inp2 = Colors.Red;
    private Color _Inp3 = Colors.Red;
    private Color _Inp4 = Colors.Red;
    private Color _Inp5 = Colors.Red;
    private Color _Inp6 = Colors.Red;
    private Color _Inp7 = Colors.Red;

    private Color _RERD = Colors.Red;
    private Color _RA = Colors.Red;
    private Color _REZ = Colors.Red;

    private Color _Z0 = Colors.Red;
    private Color _Z1 = Colors.Red;
    private Color _Z2 = Colors.Red;
    private Color _Z3 = Colors.Red;

    public Color LD0
    {
        get => _LD0;
        set
        {
            _LD0 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color LD1
    {
        get => _LD1;
        set
        {
            _LD1 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color LD2
    {
        get => _LD2;
        set
        {
            _LD2 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color LD3
    {
        get => _LD3;
        set
        {
            _LD3 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color L1
    {
        get => _L1;
        set
        {
            _L1 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color L2
    {
        get => _L2;
        set
        {
            _L2 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color LD4
    {
        get => _LD4;
        set
        {
            _LD4 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color LD5
    {
        get => _LD5;
        set
        {
            _LD5 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color LD6
    {
        get => _LD6;
        set
        {
            _LD6 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color LD7
    {
        get => _LD7;
        set
        {
            _LD7 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color LERD1
    {
        get => _LERD1;
        set
        {
            _LERD1 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color LERD2
    {
        get => _LERD2;
        set
        {
            _LERD2 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color M1
    {
        get => _M1;
        set
        {
            _M1 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color M2
    {
        get => _M2;
        set
        {
            _M2 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color M3
    {
        get => _M3;
        set
        {
            _M3 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color MD0
    {
        get => _MD0;
        set
        {
            _MD0 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color MD1
    {
        get => _MD1;
        set
        {
            _MD1 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color MD2
    {
        get => _MD2;
        set
        {
            _MD2 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color MD3
    {
        get => _MD3;
        set
        {
            _MD3 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color MD4
    {
        get => _MD4;
        set
        {
            _MD4 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color MD5
    {
        get => _MD5;
        set
        {
            _MD5 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color MD6
    {
        get => _MD6;
        set
        {
            _MD6 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color MD7
    {
        get => _MD7;
        set
        {
            _MD7 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color Inp0
    {
        get => _Inp0;
        set
        {
            _Inp0 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color Inp1
    {
        get => _Inp1;
        set
        {
            _Inp1 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color Inp2
    {
        get => _Inp2;
        set
        {
            _Inp2 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color Inp3
    {
        get => _Inp3;
        set
        {
            _Inp3 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color Inp4
    {
        get => _Inp4;
        set
        {
            _Inp4 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color Inp5
    {
        get => _Inp5;
        set
        {
            _Inp5 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color Inp6
    {
        get => _Inp6;
        set
        {
            _Inp6 = value;
            OnPropertyChanged();
            ProcessedValue_MS_one();
        }
    }

    public Color Inp7
    {
        get => _Inp7;
        set
        {
            _Inp7 = value;
            OnPropertyChanged();
        }
    }

    public Color RERD
    {
        get => _RERD;
        set
        {
            _RERD = value;
            OnPropertyChanged();
        }
    }

    public Color RA
    {
        get => _RA;
        set
        {
            _RA = value;
            OnPropertyChanged();
        }
    }

    public Color REZ
    {
        get => _REZ;
        set
        {
            _REZ = value;
            OnPropertyChanged();
        }
    }
    public event EventHandler<Color> ColorChanged;
    public Color LOut0
    {
        get => _LOut0;
        set
        {
            _LOut0 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color LOut1
    {
        get => _LOut1;
        set
        {
            _LOut1 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color MOut
    {
        get => _MOut;
        set
        {
            _MOut = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color MOut_inv
    {
        get => _MOut_inv;
        set
        {
            _MOut_inv = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }
    public Color Z0
    {
        get => _Z0;
        set
        {
            _Z0 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Z1
    {
        get => _Z1;
        set
        {
            _Z1 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Z2
    {
        get => _Z2;
        set
        {
            _Z2 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Z3
    {
        get => _Z3;
        set
        {
            _Z3 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    // Конец
    public void ProcessedValue_MS_one()
    {
        if(DigitalConverter(LERD1) == 0)
        {
            string binaryWord = $"{DigitalConverter(L1)}{DigitalConverter(L2)}";
            switch (binaryWord)
            {
                case "00":
                    {
                        LOut0 = LD0;
                        break;
                    }
                case "01":
                    {
                        LOut0 = LD1;
                        break;
                    }
                case "10":
                    {
                        LOut0 = LD2;
                        break;
                    }
                case "11":
                    {
                        LOut0 = LD3;
                        break;
                    }
            }
        }
        if (DigitalConverter(LERD2) == 0)
        {
            string binaryWord = $"{DigitalConverter(L1)}{DigitalConverter(L2)}";
            switch (binaryWord)
            {
                case "00":
                    {
                        LOut1 = LD4;
                        break;
                    }
                case "01":
                    {
                        LOut1 = LD5;
                        break;
                    }
                case "10":
                    {
                        LOut1 = LD6;
                        break;
                    }
                case "11":
                    {
                        LOut1 = LD7;
                        break;
                    }
            }
        }
        return;
    }
    public int DigitalConverter(Color inputValues)
    {
        return inputValues == Colors.Transparent ? 0 : 1;
    }
    public multplex()
    {
        InitializeComponent();
        BindingContext = this;
        ProcessedValue_MS_one();
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