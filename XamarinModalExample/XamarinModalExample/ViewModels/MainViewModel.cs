using System.Windows.Input;
using Xamarin.Forms;
using XamarinModalExample.ViewModels.Base;

namespace XamarinModalExample.ViewModels
{
    public class MainViewModel : ExtendedBindableObject
    {
        private bool _showHelpModal;

        public MainViewModel()
        {
            ShowHelp = new Command(ShowHelpAsync);
        }

        public ICommand ShowHelp { get; }

        public bool ShowHelpModal
        {
            get => _showHelpModal;
            set
            {
                if (value == _showHelpModal) return;
                _showHelpModal = value;
                RaisePropertyChanged(() => ShowHelpModal);
            }
        }

        private void ShowHelpAsync()
        {
            ShowHelpModal = true;
        }
    }
}