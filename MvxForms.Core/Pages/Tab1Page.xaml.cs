using System;
using System.Collections.Generic;
using MvvmCross.Forms.Views;
using MvvmCross.Forms.Views.Attributes;
using MvxForms.Core.ViewModels;
using Xamarin.Forms;

namespace MvxForms.Core.Pages
{
    [MvxTabbedPagePresentation(WrapInNavigationPage = false, Title = "Tab1")]
    public partial class Tab1Page : MvxContentPage<Tab1ViewModel>
    {
        public Tab1Page()
        {
            InitializeComponent();
        }
    }
}
