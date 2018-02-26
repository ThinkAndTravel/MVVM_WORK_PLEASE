using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvxForms.Core.ViewModels
{
    public class SplitRootViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public SplitRootViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            try
            {
                ShowInitialMenuCommand = new MvxAsyncCommand(ShowInitialViewModels);
                ShowDetailCommand = new MvxAsyncCommand(ShowDetailViewModel);
          //      ShowDetailCommand.Execute();
                ShowInitialMenuCommand.Execute();
            }catch(System.Exception e)
            {

            }
        }

        public IMvxAsyncCommand ShowInitialMenuCommand { get; private set; }

        public IMvxAsyncCommand ShowDetailCommand { get; private set; }

        private async Task ShowInitialViewModels()
        {
            await _navigationService.Navigate<SplitMasterViewModel>();
        }

        private async Task ShowDetailViewModel()
        {
            await _navigationService.Navigate<SplitDetailViewModel>();
        }
    }
}
