using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace PopupX2.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.InstalledApp("com.companyname.popupx2").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}