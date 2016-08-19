using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using PlanningPoker.Core.UI;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace PlanningPoker.Android
{
    [Activity(Label = "PlanningPoker.Android", MainLauncher = true, Icon = "@mipmap/ic_launcher")]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            Forms.Init(this, savedInstanceState);


            LoadApplication(new App());
        }
    }
}

