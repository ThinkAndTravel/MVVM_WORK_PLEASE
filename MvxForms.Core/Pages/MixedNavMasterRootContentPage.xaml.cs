using MvvmCross.Forms.Views;
using MvvmCross.Forms.Views.Attributes;
using MvxForms.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace MvxForms.Core.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	[MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, WrapInNavigationPage = true)]
    public partial class MixedNavMasterRootContentPage : MvxContentPage<MixedNavMasterRootContentViewModel>
	{
		public MixedNavMasterRootContentPage ()
		{
			InitializeComponent ();
		}
	}
}