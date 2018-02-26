using Android.App;
using Android.OS;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Platform;
using MvvmCross.Forms.Droid;
using MvvmCross.Forms.Droid.Views;
using MvvmCross.Platform;
using Xamarin.Forms;
using MvvmCross.Droid.Views;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Platform;
using MvvmCross.Forms.Views;
using Android.Content;

namespace MvxForms.Droid
{
//    [Activity(Label = "MasterDetailApplicationActivity", Icon = "@android:color/transparent")]
    [Activity(Label = "MvxForms.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class MainActivity : MvxFormsApplicationActivity
    {
    /*    protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Required for proper Push notifications handling
            var setupSingleton = MvxAndroidSetupSingleton.EnsureSingletonAvailable(ApplicationContext);
            setupSingleton.EnsureInitialized();
           

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(FormsApplication);
        }
        */
    }
}
