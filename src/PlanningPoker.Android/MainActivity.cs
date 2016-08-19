using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace PlanningPoker.Android
{
    [Activity(Label = "PlanningPoker.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;


            base.OnCreate(savedInstanceState);

            Forms.Init(this, savedInstanceState);

            Toolkit.Init();

            LoadApplication(new App());
        }
    }
}

