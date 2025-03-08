using DigitalSchema.Chips;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DigitalSchema.Models;
using Microsoft.Maui.Controls.Shapes;

namespace DigitalSchema
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        Dictionary<Ellipse, Ellipse> Commutation = new Dictionary<Ellipse, Ellipse>();
        public Ellipse? SelectedEllipse { get; set; }

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
                Reverce();
            }
        }

        public void Reverce()
        {
            ChipOne.InputValues_01 = ChipOne.InputValues_01 == Colors.Transparent ? Colors.Red : Colors.Transparent;
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            ChipOne.EllipseTapped += OnEllipseTapped;
            ChipOne.ExitEllipseTapped += OnExitEllipseTapped;
            ChipOne.ColorChanged += OnEllipseColorChanged;
            ChipTwo.EllipseTapped += OnEllipseTapped;
            ChipTwo.ExitEllipseTapped += OnExitEllipseTapped;
            ChipTwo.ColorChanged += OnEllipseColorChanged;
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
                    SelectedEllipse = null;
                }
                
            }
            else
            {
                //ProgramProcessingCycle();
            }
        }
        private void OnExitEllipseTapped(object sender, Ellipse ellipse) 
        {
            if (Editing == true)
            {
                if (SelectedEllipse == null)
                {
                    DisplayAlert("Уведомление", $"Нажат Ellipse", "OK");
                    SelectedEllipse = ellipse;
                }
            }
        }

    }
}
