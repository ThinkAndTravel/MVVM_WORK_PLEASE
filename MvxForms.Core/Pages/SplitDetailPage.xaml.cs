using System;
using System.Collections.Generic;
using MvvmCross.Forms.Views;
using MvvmCross.Forms.Views.Attributes;
using Xamarin.Forms;
using MvxForms.Core.ViewModels;

namespace MvxForms.Core.Pages
{
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail)]
    public partial class SplitDetailPage : MvxContentPage<SplitDetailViewModel>
    {
        public SplitDetailPage()
        {
            InitializeComponent();
        }
    }
}
