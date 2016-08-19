using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanningPoker.Core.UI.Pages;
using Xamarin.Forms;

namespace PlanningPoker.Core.UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CardOverviewPage());


            //switch (Device.OS)
            //{
            //    case TargetPlatform.Android:
            //        MainPage = new RootPageAndroid();
            //        break;
            //    case TargetPlatform.iOS:
            //        MainPage = new FancyNavigationPage(new RootPageiOS());
            //        break;
            //    case TargetPlatform.Windows:
            //    case TargetPlatform.WinPhone:
            //        MainPage = new RootPageWindows();
            //        break;
            //    default:
            //        throw new NotImplementedException();
            //}
        }
    }
}
