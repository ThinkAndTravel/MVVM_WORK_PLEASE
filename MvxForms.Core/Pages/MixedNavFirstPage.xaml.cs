using MvvmCross.Forms.Views;
using MvvmCross.Forms.Views.Attributes;
using MvxForms.Core.ViewModels;

namespace MvxForms.Core.Pages
{
    [MvxContentPagePresentation(WrapInNavigationPage = false)]
    public partial class MixedNavFirstPage : MvxContentPage<MixedNavFirstViewModel>
    {
        public MixedNavFirstPage()
        {
            InitializeComponent();
        }
    }
}