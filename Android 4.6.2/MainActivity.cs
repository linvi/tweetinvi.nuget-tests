using System.Threading.Tasks;
using Android.App;
using Android.Widget;
using Android.OS;
using Tweetinvi;

namespace Android_4._6._2
{
    [Activity(Label = "Android_4._6._2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            Auth.SetUserCredentials("CONSUMER_KEY", "CONSUMER_SECRET", "ACCESS_TOKEN", "ACCESS_TOKEN_SECRET");

            var user = await UserAsync.GetAuthenticatedUser();

            button.Click += delegate { button.Text = string.Format("{0} clicked {1} times!", user, count++); };
        }
    }
}
