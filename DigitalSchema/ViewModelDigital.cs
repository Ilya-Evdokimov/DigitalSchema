using System.ComponentModel;
using System.Runtime.CompilerServices;
using DigitalSchema.Models;

namespace DigitalSchema
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ModelDigital _userInputModel;
        public ModelDigital ModelDigital
        {
            get => _userInputModel;
            set
            {
                if (_userInputModel != value)
                {
                    _userInputModel = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _switchStates = false;
        public bool SwitchStates
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
            ModelDigital = new ModelDigital(true);
        }

        public void UpdateSwitch()
        {
            SwitchStates = ModelDigital.SwitchOne;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
