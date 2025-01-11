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
        public MainViewModel() { }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
