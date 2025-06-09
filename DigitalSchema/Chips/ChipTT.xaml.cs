using Microsoft.Maui.Controls.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DigitalSchema.Chips;

public partial class ChipTT : ContentView, INotifyPropertyChanged
{
    private Color _InputValues_S = Colors.Red;
    private Color _InputValues_K1 = Colors.Red;
    private Color _InputValues_K2 = Colors.Red;
    private Color _InputValues_K3 = Colors.Red;
    private Color _InputValues_C = Colors.Red;
    private Color _InputValues_J1 = Colors.Red;
    private Color _InputValues_J2 = Colors.Red;
    private Color _InputValues_J3 = Colors.Red;
    private Color _InputValues_R = Colors.Red;
    private Color _OutputValues = Colors.Red;
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
    public Color InputValues_K1
    {
        get => _InputValues_K1;
        set
        {
            _InputValues_K1 = value;
            OnPropertyChanged();
            ProcessedValues_ChipTT();
        }
    }
    public Color InputValues_K2
    {
        get => _InputValues_K2;
        set
        {
            _InputValues_K2 = value;
            OnPropertyChanged();
            ProcessedValues_ChipTT();
        }
    }
    public Color InputValues_K3
    {
        get => _InputValues_K3;
        set
        {
            _InputValues_K3 = value;
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
    public Color InputValues_J1
    {
        get => _InputValues_J1;
        set
        {
            _InputValues_J1 = value;
            OnPropertyChanged();
            ProcessedValues_ChipTT();
        }
    }
    public Color InputValues_J2
    {
        get => _InputValues_J2;
        set
        {
            _InputValues_J2 = value;
            OnPropertyChanged();
            ProcessedValues_ChipTT();
        }
    }
    public Color InputValues_J3
    {
        get => _InputValues_J3;
        set
        {
            _InputValues_J3 = value;
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


    private bool _currentState = false;  // Переменная для хранения состояния триггера
    private bool _prevClockState = false;
    public void ProcessedValues_ChipTT()
    {
        bool C = DigitalConverter(InputValues_C) == 1;  // Тактовый сигнал
        bool S = DigitalConverter(InputValues_S) != 1;  // Set (активный 0, инвертирован)
        bool R = DigitalConverter(InputValues_R) != 1;  // Reset (активный 0, инвертирован)

        // Многоразрядные входы J и K (достаточно хотя бы одного вкл.)
        bool J = DigitalConverter(InputValues_J1) == 1 &&
                  DigitalConverter(InputValues_J2) == 1 &&
                  DigitalConverter(InputValues_J3) == 1;

        bool K = DigitalConverter(InputValues_K1) == 1 &&
                  DigitalConverter(InputValues_K2) == 1 &&
                  DigitalConverter(InputValues_K3) == 1;

        // 1. Проверка асинхронных входов (приоритет выше тактового сигнала)
        if (S && R)  // S=0, R=0 (т.к. инвертированы)
        {
            // Недопустимое состояние (Q и !Q = 1)
            OutputValues = Colors.Red;
            OutputValues_Inv = Colors.Red;
            _currentState = true;  // Неопределённое состояние
        }
        else if (S)  // S=0 (активный уровень)
        {
            // Асинхронная установка (Q=1)
            OutputValues = Colors.Red;
            OutputValues_Inv = Colors.Transparent;
            _currentState = true;
        }
        else if (R)  // R=0 (активный уровень)
        {
            // Асинхронный сброс (Q=0)
            OutputValues = Colors.Transparent;
            OutputValues_Inv = Colors.Red;
            _currentState = false;
        }
        // 2. Синхронная работа (если нет асинхронных воздействий)
        else if (C && !_prevClockState)  // Обработка фронта (0→1)
        {
            if (J && K)
            {
                // Режим T-триггера (инверсия состояния)
                _currentState = !_currentState;
            }
            else if (J)
            {
                // Установка (Q=1)
                _currentState = true;
            }
            else if (K)
            {
                // Сброс (Q=0)
                _currentState = false;
            }
            // Если J=0 и K=0 — состояние сохраняется (_currentState не меняется)

            // Обновляем выходы
            OutputValues = _currentState ? Colors.Red : Colors.Transparent;
            OutputValues_Inv = _currentState ? Colors.Transparent : Colors.Red;
        }

        _prevClockState = C;  // Сохраняем состояние такта для детектирования фронта
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

    public ChipTT()
	{
		InitializeComponent();
        BindingContext = this;
        ProcessedValues_ChipTT();
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}