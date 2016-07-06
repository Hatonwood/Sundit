using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Sundit
{
    [Activity(Label = "Sundit", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.MyButton);

            //Profile pic query
            ImageButton profilepic = FindViewById<ImageButton>(Resource.Id.profilepic);

            //username query
            TextView username = FindViewById<TextView>(Resource.Id.username);
            username.Text = "Username";

            //properties image
            ImageButton properties = FindViewById<ImageButton>(Resource.Id.properties);
            //properties.SetImageResource;

            //refresh Timeline
            //query to the server
        }
    }
}

