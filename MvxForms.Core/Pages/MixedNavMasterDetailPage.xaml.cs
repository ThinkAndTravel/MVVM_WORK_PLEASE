using MvvmCross.Forms.Views;
using MvvmCross.Forms.Views.Attributes;
using MvxForms.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace MvxForms.Core.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Master, WrapInNavigationPage = false)]
    public partial class MixedNavMasterDetailPage : MvxContentPage<MixedNavMasterDetailViewModel>
    {
        public MixedNavMasterDetailPage()
        {
            InitializeComponent();
        }
    }
}