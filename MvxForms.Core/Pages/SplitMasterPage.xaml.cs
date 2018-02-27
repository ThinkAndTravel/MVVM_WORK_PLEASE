using System;
using System.Collections.Generic;
using MvvmCross.Forms.Views;
using MvvmCross.Forms.Views.Attributes;
using MvxForms.Core.ViewModels;
using Xamarin.Forms;

namespace MvxForms.Core.Pages
{
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Master)]
    public partial class SplitMasterPage : MvxContentPage<SplitMasterViewModel>
    {
        public SplitMasterPage()
        {
            InitializeComponent();
        }
    }
}
