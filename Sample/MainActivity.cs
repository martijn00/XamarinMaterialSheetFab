using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Com.Gordonwong.Materialsheetfab;
using Android.Support.V7.App;

namespace Sample
{
    [Activity (Label = "Sample", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.MaterialSheetFab")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            View sheetView = FindViewById(Resource.Id.fab_sheet);
            View overlay = FindViewById(Resource.Id.overlay);
            int sheetColor = Resources.GetColor(Resource.Color.background_card);
            int fabColor = Resources.GetColor(Resource.Color.theme_accent);

            // Initialize material sheet FAB
            var materialSheetFab = new MaterialSheetFab(fab, sheetView, overlay, sheetColor, fabColor);
        }
    }
}


