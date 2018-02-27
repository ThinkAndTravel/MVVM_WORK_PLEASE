using System;
using System.Collections.Generic;
using MvvmCross.Forms.Views;
using MvxForms.Core.ViewModels;
using Xamarin.Forms;

namespace MvxForms.Core.Pages
{
    public partial class NestedChildPage : MvxContentPage<NestedChildViewModel>
    {
        public NestedChildPage()
        {
            InitializeComponent();
        }
    }
}
