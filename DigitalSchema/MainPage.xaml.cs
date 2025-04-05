using DigitalSchema.Chips;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DigitalSchema.Models;
using Microsoft.Maui.Controls.Shapes;

namespace DigitalSchema
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public Dictionary<Ellipse, Ellipse> Commutation = new Dictionary<Ellipse, Ellipse>(); // Невизуальная часть привязки
        public Dictionary<Ellipse, Label> bindingLabels = new Dictionary<Ellipse, Label>(); // Визуальная часть привязки
        public Ellipse? SelectedEllipse { get; set; }

        private int number;
        private bool _editing;
        public bool Editing
        {
            get => _editing;
            set
            {
                _editing = value;
                OnPropertyChanged();
            }
        }

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
            }
        }
        public bool Switch2
        {
            get => _switch2;
            set
            {
                _switch2 = value;
                OnPropertyChanged();
            }
        }
        public bool Switch3
        {
            get => _switch3;
            set
            {
                _switch3 = value;
                OnPropertyChanged();
            }
        }
        public bool Switch4
        {
            get => _switch4;
            set
            {
                _switch4 = value;
                OnPropertyChanged();
            }
        }

        public void Reverce()
        {
            //ChipOne.InputValues_01 = ChipOne.InputValues_01 == Colors.Transparent ? Colors.Red : Colors.Transparent;
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            number = 0;

            UM11UI.EllipseTapped += OnEllipseTapped;
            UM11UI.ExitEllipseTapped += OnExitEllipseTapped;
            UM11UI.ColorChanged += OnEllipseColorChanged;

            ChipOne.EllipseTapped += OnEllipseTapped;
            ChipOne.ExitEllipseTapped += OnExitEllipseTapped;
            ChipOne.ColorChanged += OnEllipseColorChanged;
            ChipTwo.EllipseTapped += OnEllipseTapped;
            ChipTwo.ExitEllipseTapped += OnExitEllipseTapped;
            ChipTwo.ColorChanged += OnEllipseColorChanged;

            ChipOne2.EllipseTapped += OnEllipseTapped;
            ChipOne2.ExitEllipseTapped += OnExitEllipseTapped;
            ChipOne2.ColorChanged += OnEllipseColorChanged;
            ChipTwo2.EllipseTapped += OnEllipseTapped;
            ChipTwo2.ExitEllipseTapped += OnExitEllipseTapped;
            ChipTwo2.ColorChanged += OnEllipseColorChanged;

            Chip3And1.EllipseTapped += OnEllipseTapped;
            Chip3And1.ExitEllipseTapped += OnExitEllipseTapped;
            Chip3And1.ColorChanged += OnEllipseColorChanged;
            Chip3And2.EllipseTapped += OnEllipseTapped;
            Chip3And2.ExitEllipseTapped += OnExitEllipseTapped;
            Chip3And2.ColorChanged += OnEllipseColorChanged;

            Chip3OrTwo2.EllipseTapped += OnEllipseTapped;
            Chip3OrTwo2.ExitEllipseTapped += OnExitEllipseTapped;
            Chip3OrTwo2.ColorChanged += OnEllipseColorChanged;

            ChipTT1.EllipseTapped += OnEllipseTapped;
            ChipTT1.ExitEllipseTapped += OnExitEllipseTapped;
            ChipTT1.ColorChanged += OnEllipseColorChanged;
            Chip4AndTwo1.EllipseTapped += OnEllipseTapped;
            Chip4AndTwo1.ExitEllipseTapped += OnExitEllipseTapped;
            Chip4AndTwo1.ColorChanged += OnEllipseColorChanged;

            Chip2XOR1.EllipseTapped += OnEllipseTapped;
            Chip2XOR1.ExitEllipseTapped += OnExitEllipseTapped;
            Chip2XOR1.ColorChanged += OnEllipseColorChanged;
        }
        private void OnEllipseColorChanged(object sender, Color newColor)
        {
            foreach (var pair in Commutation)
            {
                pair.Value.Fill = pair.Key.Fill;
            }
            return;
        }

        private void OnEllipseTapped(object sender, Ellipse ellipse) 
        {
            if (Editing == true)
            {
                if (SelectedEllipse != null)
                {

                    ellipse.Fill = SelectedEllipse.Fill;
                    Commutation[SelectedEllipse] = ellipse;

                    // Создаем новый Label
                    var label = new Label
                    {
                        Text = "I"+number, 
                        TextColor = Colors.GreenYellow,
                        FontAttributes = FontAttributes.Bold,
                        FontSize = 16,
                        VerticalOptions = ellipse.VerticalOptions,
                        HorizontalOptions = ellipse.HorizontalOptions
                    };

                    // Получаем Grid, в котором находится Ellipse
                    var grid = ellipse.Parent as Grid;

                    if (grid != null)
                    {
                        // Добавляем Label в Grid
                        grid.Children.Add(label);
                        label.Margin = new Thickness(ellipse.Margin.Left - 33, ellipse.Margin.Top - 8, ellipse.Margin.Right, ellipse.Margin.Bottom);
                        bindingLabels[ellipse] = label;
                    }

                    var Outlabel = new Label
                    {
                        Text = "O" + number,
                        TextColor = Colors.GreenYellow,
                        FontAttributes = FontAttributes.Bold,
                        FontSize = 16,
                        VerticalOptions = SelectedEllipse.VerticalOptions,
                        HorizontalOptions = SelectedEllipse.HorizontalOptions
                    };

                    // Получаем Grid, в котором находится Ellipse
                    var Outgrid = SelectedEllipse.Parent as Grid;

                    if (Outgrid != null)
                    {
                        // Добавляем Label в Grid
                        Outgrid.Children.Add(Outlabel);
                        Outlabel.Margin = new Thickness(SelectedEllipse.Margin.Left, SelectedEllipse.Margin.Top - 8, SelectedEllipse.Margin.Right-33, SelectedEllipse.Margin.Bottom);
                        bindingLabels[SelectedEllipse] = Outlabel;
                    }

                    number++;
                    SelectedEllipse = null;
                }
            }
            else
            {
            }
        }
        private void OnExitEllipseTapped(object sender, Ellipse ellipse) 
        {
            if (Editing == true)
            {
                if (SelectedEllipse == null)
                {
                    //DisplayAlert("Уведомление", $"Нажат Ellipse", "OK");
                    SelectedEllipse = ellipse;
                }
            }
        }
    }
}
