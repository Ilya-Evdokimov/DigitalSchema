using Microsoft.Maui.Controls.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DigitalSchema.Chips;

public partial class dc : ContentView, INotifyPropertyChanged
{
    private Color _RD1_one = Colors.Red;
    private Color _RD2_one = Colors.Red;
    private Color _RD3_one = Colors.Red;
    private Color _RD4_one = Colors.Red;

    private Color _One_one = Colors.Red;
    private Color _Two_one = Colors.Red;

    private Color _Out1_1 = Colors.Transparent;
    private Color _Out2_1 = Colors.Transparent;
    private Color _Out3_1 = Colors.Transparent;
    private Color _Out4_1 = Colors.Transparent;
    private Color _Out5_1 = Colors.Transparent;
    private Color _Out6_1 = Colors.Transparent;
    private Color _Out7_1 = Colors.Transparent;
    private Color _Out8_1 = Colors.Transparent;

    // Второй декодер
    private Color _RD1_2 = Colors.Red;
    private Color _RD2_2 = Colors.Red;
    private Color _RD3_2 = Colors.Red;

    private Color _One_2 = Colors.Red;
    private Color _Two_2 = Colors.Red;
    private Color _Thr_2 = Colors.Red;

    private Color _Out1_2 = Colors.Transparent;
    private Color _Out2_2 = Colors.Transparent;
    private Color _Out3_2 = Colors.Transparent;
    private Color _Out4_2 = Colors.Transparent;
    private Color _Out5_2 = Colors.Transparent;
    private Color _Out6_2 = Colors.Transparent;
    private Color _Out7_2 = Colors.Transparent;
    private Color _Out8_2 = Colors.Transparent;

    public Color RD1_one
    {
        get => _RD1_one;
        set
        {
            _RD1_one = value;
            OnPropertyChanged();
            ProcessedValues_DC_one();
        }
    }

    public Color RD2_one
    {
        get => _RD2_one;
        set
        {
            _RD2_one = value;
            OnPropertyChanged();
            ProcessedValues_DC_one();
        }
    }

    public Color RD3_one
    {
        get => _RD3_one;
        set
        {
            _RD3_one = value;
            OnPropertyChanged();
            ProcessedValues_DC_one();
        }
    }

    public Color RD4_one
    {
        get => _RD4_one;
        set
        {
            _RD4_one = value;
            OnPropertyChanged();
            ProcessedValues_DC_one();
        }
    }

    public Color One_one
    {
        get => _One_one;
        set
        {
            _One_one = value;
            OnPropertyChanged();
            ProcessedValues_DC_one();
        }
    }

    public Color Two_one
    {
        get => _Two_one;
        set
        {
            _Two_one = value;
            OnPropertyChanged();
            ProcessedValues_DC_one();
        }
    }
    // Второй декодер 
    public Color RD1_2
    {
        get => _RD1_2;
        set
        {
            _RD1_2 = value;
            OnPropertyChanged();
            ProcessedValue_DC_two();
        }
    }

    public Color RD2_2
    {
        get => _RD2_2;
        set
        {
            _RD2_2 = value;
            OnPropertyChanged();
            ProcessedValue_DC_two();
        }
    }

    public Color RD3_2
    {
        get => _RD3_2;
        set
        {
            _RD3_2 = value;
            OnPropertyChanged();
            ProcessedValue_DC_two();
        }
    }

    public Color One_2
    {
        get => _One_2;
        set
        {
            _One_2 = value;
            OnPropertyChanged();
            ProcessedValue_DC_two();
        }
    }

    public Color Two_2
    {
        get => _Two_2;
        set
        {
            _Two_2 = value;
            OnPropertyChanged();
            ProcessedValue_DC_two();
        }
    }

    public Color Thr_2
    {
        get => _Thr_2;
        set
        {
            _Thr_2 = value;
            OnPropertyChanged();
            ProcessedValue_DC_two();
        }
    }
    // ========== {Выводы} ========== 
    public event EventHandler<Color> ColorChanged;
    public Color Out1_1
    {
        get => _Out1_1;
        set
        {
            _Out1_1 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Out2_1
    {
        get => _Out2_1;
        set
        {
            _Out2_1 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Out3_1
    {
        get => _Out3_1;
        set
        {
            _Out3_1 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Out4_1
    {
        get => _Out4_1;
        set
        {
            _Out4_1 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Out5_1
    {
        get => _Out5_1;
        set
        {
            _Out5_1 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Out6_1
    {
        get => _Out6_1;
        set
        {
            _Out6_1 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Out7_1
    {
        get => _Out7_1;
        set
        {
            _Out7_1 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Out8_1
    {
        get => _Out8_1;
        set
        {
            _Out8_1 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    // Второй декодер
    public Color Out1_2
    {
        get => _Out1_2;
        set
        {
            _Out1_2 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Out2_2
    {
        get => _Out2_2;
        set
        {
            _Out2_2 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Out3_2
    {
        get => _Out3_2;
        set
        {
            _Out3_2 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Out4_2
    {
        get => _Out4_2;
        set
        {
            _Out4_2 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Out5_2
    {
        get => _Out5_2;
        set
        {
            _Out5_2 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Out6_2
    {
        get => _Out6_2;
        set
        {
            _Out6_2 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Out7_2
    {
        get => _Out7_2;
        set
        {
            _Out7_2 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    public Color Out8_2
    {
        get => _Out8_2;
        set
        {
            _Out8_2 = value;
            OnPropertyChanged();
            ColorChanged?.Invoke(this, value);
        }
    }

    // Конец
    public void ProcessedValue_DC_two()
    {
        if(DigitalConverter(RD1_2) == 1 && DigitalConverter(RD2_2) == 0 && DigitalConverter(RD3_2) == 0)
        {
            Out1_2 = Colors.Transparent;
            Out2_2 = Colors.Transparent;
            Out3_2 = Colors.Transparent;
            Out4_2 = Colors.Transparent;
            Out5_2 = Colors.Transparent;
            Out6_2 = Colors.Transparent;
            Out7_2 = Colors.Transparent;
            Out8_2 = Colors.Transparent;
            string binaryWord = $"{DigitalConverter(One_2)}{DigitalConverter(Two_2)}{DigitalConverter(Thr_2)}";
            switch(binaryWord)
            {
                case "000":
                    {
                        Out1_2 = Colors.Red;
                        break;
                    }
                case "001":
                    {
                        Out2_2 = Colors.Red;
                        break;
                    }
                case "010":
                    {
                        Out3_2 = Colors.Red;
                        break;
                    }
                case "011":
                    {
                        Out4_2 = Colors.Red;
                        break;
                    }
                case "100":
                    {
                        Out5_2 = Colors.Red;
                        break;
                    }
                case "101":
                    {
                        Out6_2 = Colors.Red;
                        break;
                    }
                case "110":
                    {
                        Out7_2 = Colors.Red;
                        break;
                    }
                case "111":
                    {
                        Out8_2 = Colors.Red;
                        break;
                    }
            }
        }
        return;
    }

    public void ProcessedValues_DC_one()
    {
        int res = DigitalConverter(One_one) + DigitalConverter(Two_one);
        if (res == 0)
        {
            if (DigitalConverter(RD1_one) == 0 && DigitalConverter(RD2_one) == 1)
            {
                Out1_1 = Colors.Red;
                Out2_1 = Colors.Transparent;
                Out3_1 = Colors.Transparent;
                Out4_1 = Colors.Transparent;
            }
            if (DigitalConverter(RD3_one) == 0 && DigitalConverter(RD4_one) == 0)
            {
                Out5_1 = Colors.Red;
                Out6_1 = Colors.Transparent;
                Out7_1 = Colors.Transparent;
                Out8_1 = Colors.Transparent;
            }
        }
        else if (res == 1)
        {
            if (DigitalConverter(One_one) == 0)
            {
                if (DigitalConverter(RD1_one) == 0 && DigitalConverter(RD2_one) == 1)
                {
                    Out1_1 = Colors.Transparent;
                    Out2_1 = Colors.Red;
                    Out3_1 = Colors.Transparent;
                    Out4_1 = Colors.Transparent;
                }
                if (DigitalConverter(RD3_one) == 0 && DigitalConverter(RD4_one) == 0)
                {
                    Out5_1 = Colors.Transparent;
                    Out6_1 = Colors.Red;
                    Out7_1 = Colors.Transparent;
                    Out8_1 = Colors.Transparent;
                }
            }
            else
            {
                if (DigitalConverter(RD1_one) == 0 && DigitalConverter(RD2_one) == 1)
                {
                    Out1_1 = Colors.Transparent;
                    Out2_1 = Colors.Transparent;
                    Out3_1 = Colors.Red;
                    Out4_1 = Colors.Transparent;
                }
                if (DigitalConverter(RD3_one) == 0 && DigitalConverter(RD4_one) == 0)
                {
                    Out5_1 = Colors.Transparent;
                    Out6_1 = Colors.Transparent;
                    Out7_1 = Colors.Red;
                    Out8_1 = Colors.Transparent;
                }
            }
        }
        else if (res == 2)
        {
            if (DigitalConverter(RD1_one) == 0 && DigitalConverter(RD2_one) == 1)
            { 
                Out1_1 = Colors.Transparent;
                Out2_1 = Colors.Transparent;
                Out3_1 = Colors.Transparent;
                Out4_1 = Colors.Red;
            }
            if (DigitalConverter(RD3_one) == 0 && DigitalConverter(RD4_one) == 0)
            {
                Out5_1 = Colors.Transparent;
                Out6_1 = Colors.Transparent;
                Out7_1 = Colors.Transparent;
                Out8_1 = Colors.Red;
            }

        }
        if (DigitalConverter(RD1_one) != 0 || DigitalConverter(RD2_one) != 1)
        {
            Out1_1 = Colors.Transparent;
            Out2_1 = Colors.Transparent;
            Out3_1 = Colors.Transparent;
            Out4_1 = Colors.Transparent;
        }
        if (DigitalConverter(RD3_one) != 0 || DigitalConverter(RD4_one) != 0)
        {
            Out5_1 = Colors.Transparent;
            Out6_1 = Colors.Transparent;
            Out7_1 = Colors.Transparent;
            Out8_1 = Colors.Transparent;
        }
        return;
    }
    public int DigitalConverter(Color inputValues)
    {
        return inputValues == Colors.Transparent ? 0 : 1;
    }
    public dc()
	{
		InitializeComponent();
        BindingContext = this;
        ProcessedValues_DC_one();
        ProcessedValue_DC_two();
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