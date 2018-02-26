using MvvmCross.Forms.Views;
using MvvmCross.Forms.Views.Attributes;
using MvxForms.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvxForms.Core.Pages
{
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Root)]
    public partial class MainPage : MvxMasterDetailPage<MainViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}