using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvxForms.Core.ViewModels
{
    public class WindowChildViewModel : MvxViewModel<WindowChildParam>
    {
        private readonly IMvxNavigationService _navigationService;

        private WindowChildParam _param;

        public int ParentNo => _param.ParentNo;
        public string Text => $"I'm No.{_param.ChildNo}. My parent is No.{_param.ParentNo}";

        public IMvxAsyncCommand CloseCommand => new MvxAsyncCommand(async () => await _navigationService.Close(this));

        public WindowChildViewModel(IMvxNavigationService navigationService) => _navigationService = navigationService;

        public override void Prepare(WindowChildParam param) => _param = param;
    }
}
