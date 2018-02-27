using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Forms.Views;
using MvvmCross.Forms.Views.Attributes;
using MvxForms.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvxForms.Core.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxTabbedPagePresentation(WrapInNavigationPage = false, Title = "Tab2")]
    public partial class MixedNavTab2Page : MvxContentPage<MixedNavTab2ViewModel>
    {
        public MixedNavTab2Page()
        {
            InitializeComponent();
        }
    }
}