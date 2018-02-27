using MvvmCross.Forms.Views;
using MvvmCross.Forms.Views.Attributes;
using MvxForms.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace MvxForms.Core.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	[MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail)]
    public partial class MixedNavTabsPage : MvxTabbedPage<MixedNavTabsViewModel>
	{
		public MixedNavTabsPage ()
		{
			InitializeComponent ();
		}
	}
}