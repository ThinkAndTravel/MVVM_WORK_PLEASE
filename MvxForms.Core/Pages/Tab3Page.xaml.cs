using System;
using System.Collections.Generic;
using MvvmCross.Forms.Views;
using MvvmCross.Forms.Views.Attributes;
using MvxForms.Core.ViewModels;
using Xamarin.Forms;

namespace MvxForms.Core.Pages
{
    [MvxTabbedPagePresentation(WrapInNavigationPage = false)]
    public partial class Tab3Page : MvxContentPage<Tab3ViewModel>
    {
        public Tab3Page()
        {
            InitializeComponent();
        }
    }
}
