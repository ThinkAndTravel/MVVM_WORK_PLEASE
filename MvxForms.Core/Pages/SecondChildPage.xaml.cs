using System;
using System.Collections.Generic;
using MvvmCross.Forms.Views;
using MvvmCross.Forms.Views.Attributes;
using MvxForms.Core.ViewModels;
using Xamarin.Forms;

namespace MvxForms.Core.Pages
{
    [MvxContentPagePresentation(WrapInNavigationPage = true)]
    public partial class SecondChildPage : MvxContentPage<SecondChildViewModel>
    {
        public SecondChildPage()
        {
            InitializeComponent();
        }
    }
}
