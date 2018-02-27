using System.Windows.Input;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvxForms.Core.ViewModels
{
    public class SecondChildViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public SecondChildViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            ShowNestedChildCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<NestedChildViewModel>());

            CloseCommand = new MvxAsyncCommand(async () => await _navigationService.Close(this));
        }

        public IMvxAsyncCommand ShowNestedChildCommand { get; private set; }

        public IMvxAsyncCommand CloseCommand { get; private set; }
    }
}
