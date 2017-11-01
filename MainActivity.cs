using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace XamarinYoutube
{
    [Activity(Label = "XamarinYoutube", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            var webView = FindViewById<WebView>(Resource.Id.webView);
            WebSettings settings = webView.Settings;
            settings.JavaScriptEnabled = true;
            webView.SetWebChromeClient(new WebChromeClient());
            webView.LoadUrl("https://www.youtube.com/embed/OrvSm4Tq-dE");
       }
    }
}

