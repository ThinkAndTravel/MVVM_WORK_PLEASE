using MvvmCross.Forms.Views;
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
 //   [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RootContentPage : MvxContentPage<RootContentViewModel>
    {
        public RootContentPage()
        {
            InitializeComponent();
        }
    }
}