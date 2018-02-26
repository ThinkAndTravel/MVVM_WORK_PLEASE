using System;
using System.Collections.Generic;
using MvvmCross.Forms.Views;
using MvvmCross.Forms.Views.Attributes;
using Xamarin.Forms;
using MvxForms.Core.ViewModels;

namespace MvxForms.Core.Pages
{
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Root)]
    public partial class SplitRootPage : MvxMasterDetailPage<SplitRootViewModel>
    {
        public SplitRootPage()
        {
            InitializeComponent();
            //this.Master = new SplitMasterPage();
            //this.Detail = new SplitDetailPage();
            //this.ViewModel.ShowDetailCommand.Execute();
            //this.ViewModel.ShowInitialMenuCommand.Execute();
        }
    }
}
