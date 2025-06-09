using Microsoft.Maui.Controls.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DigitalSchema.Chips;

public partial class ChipSmalTT : ContentView, INotifyPropertyChanged
{
    private Color _InputValues_S = Colors.Red;
    private Color _InputValues_R = Colors.Red;
    private Color _InputValues_D = Colors.Red;
    private Color _InputValues_C = Colors.Red;
    private Color _InputValues_OldC = Colors.Red;

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
            _InputValues_OldC = _InputValues_C;
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
        bool C = DigitalConverter(InputValues_C) == 1;  // �������� ������
        bool S;  // ��������� (Set)
        if(DigitalConverter(InputValues_S) == 1) { S = false; }
        else { S = true; }
        bool R;  // ����� (Reset)
        if (DigitalConverter(InputValues_R) == 1) { R = false; }
        else { R = true; }
        bool D = DigitalConverter(InputValues_D) == 1;  // ���� ������

        // 1. ��������� ����������� ������ (S � R ����� ���������)
        if (S && !R)
        {
            // ����������� ��������� (Q=1, !Q=0)
            OutputValues = Colors.Red;
            OutputValues_Inv = Colors.Transparent;
        }
        else if (!S && R)
        {
            // ����������� ����� (Q=0, !Q=1)
            OutputValues = Colors.Transparent;
            OutputValues_Inv = Colors.Red;
        }
        else if (S && R)
        {
            // ��������˨���� ��������� (S=1, R=1)
            // � �������� ����� ��� �������� � ��������� �������
            // ������������� ��� ����� ������ ��� ������ �����������
            OutputValues = Colors.Red;
            OutputValues_Inv = Colors.Red;
        }
        // 2. ���������� ������ (���� ��� ����������� �����������)
        else if (C)
        {
            // ������ �� ��������� ������� (D-�������)
            if (D)
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
        // 3. ���� C=0 - ��������� ����������� (�� ������ ������)
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