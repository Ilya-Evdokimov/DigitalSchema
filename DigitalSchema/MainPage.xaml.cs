using DigitalSchema.Chips;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DigitalSchema
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
    class MainViewModel:INotifyPropertyChanged
    {
        private bool[] _switchStates;
        public bool[] SwitchStates
        {
            get => _switchStates;
            set
            {
                if (_switchStates != value)
                {
                    _switchStates = value;
                    OnPropertyChanged();
                }
            }
        }
        public MainViewModel() 
        {
            SwitchStates = new bool[8];
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
