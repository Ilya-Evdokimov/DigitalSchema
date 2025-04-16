using DigitalSchema.Chips;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DigitalSchema.Models;
using Microsoft.Maui.Controls.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;
using System.Collections.ObjectModel;

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
                SelectedEllipse = null;
                _editing = value;
                OnPropertyChanged();
            }
        }
        private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex != -1)
            {
                switch(picker.SelectedIndex)
                {
                    case 0:
                        {
                            decoder.IsVisible = true;
                            break;
                        }
                    default:
                        {
                            decoder.IsVisible = false;
                            break;
                        }
                }
            }
            else
            {
                decoder.IsVisible = false;
            }
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
            ChipTT2.EllipseTapped += OnEllipseTapped;
            ChipTT2.ExitEllipseTapped += OnExitEllipseTapped;
            ChipTT2.ColorChanged += OnEllipseColorChanged;
            ChipTT3.EllipseTapped += OnEllipseTapped;
            ChipTT3.ExitEllipseTapped += OnExitEllipseTapped;
            ChipTT3.ColorChanged += OnEllipseColorChanged;
            ChipTT4.EllipseTapped += OnEllipseTapped;
            ChipTT4.ExitEllipseTapped += OnExitEllipseTapped;
            ChipTT4.ColorChanged += OnEllipseColorChanged;

            Chip4AndTwo1.EllipseTapped += OnEllipseTapped;
            Chip4AndTwo1.ExitEllipseTapped += OnExitEllipseTapped;
            Chip4AndTwo1.ColorChanged += OnEllipseColorChanged;

            Chip2XOR1.EllipseTapped += OnEllipseTapped;
            Chip2XOR1.ExitEllipseTapped += OnExitEllipseTapped;
            Chip2XOR1.ColorChanged += OnEllipseColorChanged;

            Chip2AND1.EllipseTapped += OnEllipseTapped;
            Chip2AND1.ExitEllipseTapped += OnExitEllipseTapped;
            Chip2AND1.ColorChanged += OnEllipseColorChanged;

            ChipKE1.EllipseTapped += OnEllipseTapped;
            ChipKE1.ExitEllipseTapped += OnExitEllipseTapped;
            ChipKE1.ColorChanged += OnEllipseColorChanged;
            ChipKE2.EllipseTapped += OnEllipseTapped;
            ChipKE2.ExitEllipseTapped += OnExitEllipseTapped;
            ChipKE2.ColorChanged += OnEllipseColorChanged;
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


                    // Получаем Grid, в котором находится Ellipse
                    var grid = ellipse.Parent as Grid;

                    if (grid != null)
                    {                        
                        string labelText = SelectedEllipse.WidthRequest >= 12 ? SelectedEllipse.AutomationId : ">" + number;
                        Color labelColor = SelectedEllipse.WidthRequest >= 12 ? Colors.Red : Colors.GreenYellow;

                        var label = new Label
                        {
                            Text = labelText,
                            TextColor = labelColor,
                            FontAttributes = FontAttributes.Bold,
                            FontSize = 14,
                            VerticalOptions = ellipse.VerticalOptions,
                            HorizontalOptions = ellipse.HorizontalOptions
                        };
                        // Добавляем Label в Grid
                        grid.Children.Add(label);
                        label.Margin = new Thickness(ellipse.Margin.Left - 26, ellipse.Margin.Top - 8, ellipse.Margin.Right, ellipse.Margin.Bottom);
                        bindingLabels[ellipse] = label;
                    }

                    var Outgrid = SelectedEllipse.Parent as Grid;

                    if (Outgrid != null)
                    {
                        string outLabelText = ellipse.WidthRequest >= 13 ? ellipse.AutomationId : ">" + number;
                        if(SelectedEllipse.HeightRequest == 13) { outLabelText = SelectedEllipse.AutomationId; }
                        var Outlabel = new Label
                        {
                            Text = outLabelText,
                            TextColor = Colors.GreenYellow,
                            FontAttributes = FontAttributes.Bold,
                            FontSize = 14,
                            VerticalOptions = SelectedEllipse.VerticalOptions,
                            HorizontalOptions = SelectedEllipse.HorizontalOptions
                        };

                        // Добавляем Label в Grid
                        Outgrid.Children.Add(Outlabel);
                        Outlabel.Margin = new Thickness(SelectedEllipse.Margin.Left, SelectedEllipse.Margin.Top - 8, SelectedEllipse.Margin.Right - 26, SelectedEllipse.Margin.Bottom);
                        if (SelectedEllipse.WidthRequest == 13) 
                        { 
                            Grid.SetColumn(Outlabel, Grid.GetColumn(SelectedEllipse));
                            Grid.SetRow(Outlabel, Grid.GetRow(SelectedEllipse));
                            Outlabel.Margin = new Thickness(SelectedEllipse.Margin.Left-20, SelectedEllipse.Margin.Top - 8, SelectedEllipse.Margin.Right - 26, SelectedEllipse.Margin.Bottom);
                        }
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
                bool isInDictionary = Commutation.ContainsKey(ellipse) || Commutation.ContainsValue(ellipse);

                if (isInDictionary)
                {
                    var connectedEllipse = Commutation[ellipse] ?? Commutation.FirstOrDefault(x => x.Value == ellipse).Value;
                    
                }
                if (SelectedEllipse == null)
                {
                    //DisplayAlert("Уведомление", $"Нажат Ellipse", "OK");
                    SelectedEllipse = ellipse;
                }
            }
        }
    }
}
