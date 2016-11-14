using Android.App;
using Android.Widget;
using Android.OS;

namespace ComandaSmatphone
{
    [Activity(Label = "ComandaSmatphone", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Button button = FindViewById<Button>(Resource.Id.button1);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
        }
    }
}

