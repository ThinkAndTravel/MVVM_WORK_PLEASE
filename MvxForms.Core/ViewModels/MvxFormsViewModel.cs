using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Navigation;
using System.Windows.Input;
using System;

namespace MvxForms.Core.ViewModels
{
    public class MvxFormsViewModel : MvxViewModel
    {
        readonly IMvxNavigationService navigationService;

        public MvxFormsViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public override async void ViewAppeared()
        {
            base.ViewAppeared();

            try
            {
            //    await navigationService.Navigate<Option1ViewModel>();
            }
            catch(Exception e)
            {

            }
        }

        public ICommand MainPageCommand => new MvxAsyncCommand(() => navigationService.Navigate<Option1ViewModel>());

        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }
        
        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
      //  public IMvxCommand NavigateCommand => new MvxCommand(() );

        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}